// Copyright © 2015 Lower Columbia College Computer Science Club

// This file is part of Barcode Clocking.

// Barcode Clocking is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Barcode Clocking is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.

// You should have received a copy of the GNU Affero General Public License
// along with Barcode Clocking.  If not, see <http://www.gnu.org/licenses/>.

// If you have any questions or comments, please contact the current Club
// President or Club Vice President.

using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace BarcodeClocking {
    public partial class FormGenerate : Form {
        // vars
        private char[] invalidChars;
        private SQLiteDatabase sql = new SQLiteDatabase();
        private EmployeeCard employee;

        public FormGenerate() {
            InitializeComponent();

            // set month and year selection
            ComboBoxMonth.SelectedIndex = DateTime.Today.Month - 1;
            NumericUpDownYear.Value = DateTime.Today.Year;

            // get list of invalid chars for system, excluding backspace
            List<char> tempList = Path.GetInvalidFileNameChars().ToList();
            tempList.Remove('\b');
            invalidChars = tempList.ToArray();

        }

        private bool IsFileDeleteError(Exception err) {
            return err is DirectoryNotFoundException
                || err is IOException
                || err is UnauthorizedAccessException;
        }

        private EmployeeCard GetCurrentEmployee() {
            String query = String.Format("select * from employees where employeeID={0};", TextBoxCardID.Text.Trim());
            DataTable dt = sql.GetDataTable(query);

            if (dt.Rows.Count > 0) {
                return (EmployeeCard) dt.Rows[0].ItemArray;
            } else {
                return null;
            }
        }

        private void SetEmployeeFields(ref AcroFields fields, EmployeeCard employee) {
            switch (employee.employeeType) {
                case "FWS":
                case "SWS":
                case "MST":
                case "HED":
                    fields.SetField("Work Study", "On");
                    fields.SetField("Student Help", "Off");
                    fields.SetField("WorkFirst", "Off");
                    break;

                case "Help":
                case "Tutor1":
                case "Tutor2":
                    fields.SetField("Work Study", "Off");
                    fields.SetField("Student Help", "On");
                    fields.SetField("WorkFirst", "Off");
                    break;

                case "TANF":
                    fields.SetField("Work Study", "Off");
                    fields.SetField("Student Help", "Off");
                    fields.SetField("WorkFirst", "On");
                    break;

                default:
                    fields.SetField("Work Study", "Off");
                    fields.SetField("Student Help", "Off");
                    fields.SetField("WorkFirst", "Off");
                    break;
            }

            if (employee.lastName.Length > 0) {
                fields.SetField("Last Name", employee.lastName);
                fields.SetField("First Name", employee.firstName);
                fields.SetField("Middle Int", employee.middle);
            } else {
                MessageBox.Show(this, "It appears you haven't added your last name to your profile. Please add your last name so your TimeSheet will be accepted.", "Last name missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fields.SetField("Employee ID", employee.employeeID);
            fields.SetField("Month", ComboBoxMonth.Text);
            fields.SetField("Year", NumericUpDownYear.Value.ToString());
        }

        private void SetTimesheetGui() {
            ButtonGenerate.Text = "Generating Time Sheet . . .";
            ButtonGenerate.Enabled = false;
            TextBoxCardID.Enabled = false;
            ComboBoxMonth.Enabled = false;
            NumericUpDownYear.Enabled = false;
        }

        private void ResetGui() {
            TextBoxCardID.Enabled = true;
            ComboBoxMonth.Enabled = true;
            NumericUpDownYear.Enabled = true;
            ButtonGenerate.Enabled = true;
            ButtonGenerate.Text = "Generate Time Sheet";
            TextBoxCardID.Focus();
            TextBoxCardID.SelectAll();
        }

        private void WarnAndReset(String message, String title) {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ResetGui();
        }

        private DataTable GetTimeLog() {
            return sql.GetDataTable(String.Format(@"
                select strftime('%m/%d/%Y %H:%M:%S', clockIn) as clockIn, strftime('%m/%d/%Y %H:%M:%S', clockOut) as clockOut
                from timeStamps where employeeID={0}
                and cast(strftime('%m', clockIn) as integer) = {1}
                and cast(strftime('%Y', clockIn) as integer) = {2};",
                TextBoxCardID.Text.Trim(),
                ComboBoxMonth.SelectedIndex + 1,
                (int)NumericUpDownYear.Value)
            );
        }

        private void ButtonGenerate_Click(object sender, EventArgs e) {
            double totalHours = 0;
            double[] hours = new double[31];

            PdfStamper pdfFormFiller;
            AcroFields pdfFormFields;
            DataTable dt;

            // init hours array
            for (int ii = 0; ii < 31; ii++) {
                hours[ii] = 0.0;
            }

            SetTimesheetGui();
            employee = GetCurrentEmployee();

            if (employee == null) {
                WarnAndReset("The card you entered wasn't found. Are you sure you typed it in correctly?", "Card Not Found!");
                return;
            }

            try {
                // create objects for filling in pdf
                pdfFormFiller = new PdfStamper(new PdfReader(Properties.Resources.StudentTimeSheet), new FileStream("StudentTimeSheet.pdf", FileMode.Create));
            } catch (Exception err) {
                WarnAndReset("There was an error while trying to create the PDF file.\n\n" + err.Message, "File Creation Error");
                return;
            }

            pdfFormFields = pdfFormFiller.AcroFields;
            SetEmployeeFields(ref pdfFormFields, employee);

            try {
                dt = GetTimeLog();
            } catch (Exception err) {
                WarnAndReset("There was an error while trying to open your time log file. " +
                                "Was someone playing with the database files?\n\n" +
                                err.Message + "\n\n" + err.StackTrace,
                             "File Open Error");
                return;
            }

            // get month beginning and end
            DateTime monthStart = new DateTime((int)NumericUpDownYear.Value, ComboBoxMonth.SelectedIndex + 1, 1);
            DateTime monthEnd = monthStart.AddMonths(1);

            // go through each clock-in/-out entry
            foreach (DataRow entry in dt.Rows) {
                // get start time
                DateTime clockedIn = DateTime.Parse(entry.ItemArray[0].ToString());

                // watch for an entry that doesn't have a clock-out time yet
                DateTime clockedOut;
                if (entry.ItemArray[1].ToString().Length == 0) {
                    MessageBox.Show(this, "It appears you are currently clocked in.\n\n Please make sure to clock out before printing your timesheet\n so that your hours are calcuated correctly.", "You are still clocked in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clockedOut = DateTime.Now;
                } else {
                    clockedOut = DateTime.Parse(entry.ItemArray[1].ToString());
                }

                // make sure some part(s) is/are in the respective month
                if (
                    // clocked in time is within month and year
                    (clockedIn.Month.Equals(ComboBoxMonth.SelectedIndex + 1) && clockedIn.Year.Equals((int)NumericUpDownYear.Value))
                    // clocked out time is within month and year
                    || (clockedOut.Month.Equals(ComboBoxMonth.SelectedIndex + 1) && clockedOut.Year.Equals((int)NumericUpDownYear.Value))
                    // month and year are between clocked in and out times
                    || (
                        // clocked in before date
                        (clockedIn < monthStart)
                        // clocked out after date
                        && (clockedOut >= monthEnd)
                    )
                ) {
                    // TODO make this formatting less hideous

                    // check for both times existing on the same date
                    if (clockedIn.Date.Equals(clockedOut.Date)) {
                        // figure out the difference and set time for respective day
                        hours[clockedIn.Day - 1] += (clockedOut - clockedIn).TotalHours;
                    } else {
                        // figure out time on the respective days between the times

                        // make sure clocked in time is within respective month
                        if (clockedIn < monthStart) {
                            clockedIn = monthStart;
                        }

                        // make sure clocked out time is within respective month
                        if (clockedOut >= monthEnd) {
                            clockedOut = monthEnd;
                        }

                        // figure out the difference for the first day
                        DateTime midNight = new DateTime(clockedIn.Year, clockedIn.Month, clockedIn.Day).AddDays(1.0);
                        hours[clockedIn.Day - 1] += (midNight - clockedIn).TotalHours;

                        // add 24 hours for each full day between clocked in and out times
                        clockedIn = midNight;
                        while (clockedIn.Day < clockedOut.Day) {
                            hours[clockedIn.Day - 1] += 24.0;
                            clockedIn = clockedIn.AddDays(1.0);
                        }

                        // figure out the difference for the last day
                        hours[clockedIn.Day - 1] += (clockedOut - clockedIn).TotalHours;
                    }
                }
            }

            // set logged time
            for (int ii = 0; ii < 31; ii++) {
                if (hours[ii] > 0.0) {
                    // set hours for respective day
                    pdfFormFields.SetField((ii + 1).ToString(), hours[ii].ToString("#.00"));
                }
            }

            totalHours += hours.Sum();
            pdfFormFields.SetField("Total Hrs", totalHours.ToString("#.00"));

                    
            pdfFormFields.SetField("Hourly Rate", employee.rate); // set hourly rate
            pdfFormFiller.FormFlattening = false;                          // leave the form open to subsequent manual edits
            pdfFormFiller.Close();

            try {
                // open finished pdf file
                Process openedFile = Process.Start("StudentTimeSheet.pdf");

                // wait up to 10 minutes for process to close
                ButtonGenerate.Text = "Waiting for Adobe Reader to close . . .";
                openedFile.WaitForExit(600000);

                try {
                    // check for process close or wait time-out
                    if (!openedFile.HasExited) {
                        // notify user the file was not automatically deleted
                        var result = MessageBox.Show(this, "Adobe Reader did not close within 10 " +
                                                            "minutes. It needs to be closed in order" +
                                                            " to delete the Time Sheet PDF file " +
                                                            "(recommended for security). Please close " +
                                                            "Adobe Reader and click OK to delete the " +
                                                            "file. Click Cancel to skip deleting the file.",
                                                        "Process Wait-Close Time Out",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Exclamation);
                        if (result == DialogResult.OK) {
                            File.Delete("StudentTimeSheet.pdf");
                        }
                    } else {
                        File.Delete("StudentTimeSheet.pdf");
                    }
                } catch (Exception err) when (IsFileDeleteError(err)) {
                    WarnAndReset("There was an error while trying to delete the Student Time Sheet PDF file.\n\n" + err.Message, "Delete File Error");
                }
            } catch (Exception err) {
                WarnAndReset("There was an error while trying to open the PDF file for your review.\n\n" + err.Message, "Open File Error");
            }

            ResetGui();
        }
    }
}
