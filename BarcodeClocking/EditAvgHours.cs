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

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace BarcodeClocking {
    public partial class EditAvgHours : Form {
        private SQLiteDatabase sql = new SQLiteDatabase();
        private DataTable dt;

        public EditAvgHours() {
            InitializeComponent();
            DisableUI();
        }

        private void DisableUI() {
            SaveButton.Enabled = false;
            DeleteButton.Enabled = false;
            ClearButton.Enabled = false;
            ClockInTimePicker.Enabled = false;
            ClockOutTimePicker.Enabled = false;
            DayOfWeekComboBox.Enabled = false;

        }

        private void EnableUI() {
            SaveButton.Enabled = true;
            DeleteButton.Enabled = true;
            ClearButton.Enabled = true;
            ClockInTimePicker.Enabled = true;
            ClockOutTimePicker.Enabled = true;
            DayOfWeekComboBox.Enabled = true;
        }

        private void AvgHoursGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
            if (AvgHoursGridView.SelectedRows.Count > 0) {
                DateTime clockIn;
                DateTime clockOut;
                DateTime.TryParseExact(e.Row.Cells[2].Value.ToString(), "HH:mm", null, DateTimeStyles.None, out clockIn);
                DateTime.TryParseExact(e.Row.Cells[3].Value.ToString(), "HH:mm", null, DateTimeStyles.None, out clockOut);

                ClockInTimePicker.Value = clockIn;
                ClockOutTimePicker.Value = clockOut;

                DayOfWeekComboBox.SelectedIndex = int.Parse(e.Row.Cells[1].Value.ToString()) - 1;

                // enable UI
                EnableUI();
                SaveButton.Text = "Save";
            }
        }

        private void LoadButton_Click(object sender, EventArgs e) {
            if (TextBoxCardID.Text != "") {
                try {
                    if (Helper.EmployeeExists(TextBoxCardID.Text, sql)) {
                        //Disable UIs
                        TextBoxCardID.Enabled = false;
                        LoadButton.Enabled = false;

                        dt = sql.GetDataTable("select id, dayOfWeek as Day, clockIn, clockOut from avgHours where employeeId=" + TextBoxCardID.Text + " order by dayOfWeek asc;");

                        if (dt.Rows.Count > 0) {
                            AvgHoursGridView.DataSource = dt;
                            AvgHoursGridView.ClearSelection();
                            AvgHoursGridView.Columns[0].Visible = false; // hide id column, used to determine which entry to update/remove 

                            foreach (DataGridViewColumn column in AvgHoursGridView.Columns) {
                                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                            }

                            AvgHoursGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(AvgHoursGridView_RowStateChanged);
                        } else {
                            MessageBox.Show("No entries were found for this ID,\n use the fields below to add one.", "No entries found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        SetAddButton();
                    } else {
                        throw new ArgumentException("The ID you entered does not exist, please make sure ID was entered correctly.");
                    }
                } catch (Exception err) {
                    MessageBox.Show(err.Message, "An Error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private String IndexToDay(uint idx) {
            // converts 0-indexed day of week to 3-letter abbreviation
            var days = "Sun Mon Tue Wed Thu Fri Sat".Split();
            return days[idx];
        }

        private void AvgHoursGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // cells in Day column should be formatted as day of week, and the rest are times (e.g., 3:12 PM)
            if (AvgHoursGridView.Columns[e.ColumnIndex].Name == "Day") {
                e.Value = IndexToDay(UInt32.Parse(e.Value.ToString()));
            } else {
                DateTime time;
                DateTime.TryParseExact(e.Value.ToString(), "HH:mm", null, DateTimeStyles.None, out time);
                e.Value = time.ToString("h:mm tt");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            try {
                string dayOfWeek = (DayOfWeekComboBox.SelectedIndex + 1).ToString();
                string clockIn = ClockInTimePicker.Value.ToString("HH:mm");
                string clockOut = ClockOutTimePicker.Value.ToString("HH:mm");

                Dictionary<String, String> data = new Dictionary<String, String> {
                    { "dayOfWeek", dayOfWeek },
                    { "clockIn", clockIn },
                    { "clockOut", clockOut }
                };

                if (SaveButton.Text == "Save" && AvgHoursGridView.SelectedRows.Count > 0) {
                    string entryId = AvgHoursGridView.SelectedRows[0].Cells[0].Value.ToString();

                    if (sql.Update("avgHours", data, String.Format("avgHours.id = {0}", entryId))) {
                        AvgHoursGridView.SelectedRows[0].Cells[1].Value = dayOfWeek;
                        AvgHoursGridView.SelectedRows[0].Cells[2].Value = clockIn;
                        AvgHoursGridView.SelectedRows[0].Cells[3].Value = clockOut;

                        SetAddButton();
                    }
                } else if (SaveButton.Text == "Add" && AvgHoursGridView.SelectedRows.Count == 0) {
                    // TODO see if count == 0 check is actually necessary
                    data.Add("employeeID", TextBoxCardID.Text.Trim());

                    if (sql.Insert("avgHours", data)) {
                        DataTable dt = AvgHoursGridView.DataSource as DataTable;

                        if (dt == null) {
                            dt = new DataTable();
                            dt.Columns.Add("id", typeof(int));
                            dt.Columns.Add("Day", typeof(string));
                            dt.Columns.Add("clockIn", typeof(string));
                            dt.Columns.Add("clockOut", typeof(string));

                            AvgHoursGridView.DataSource = dt; 
                            AvgHoursGridView.Columns[0].Visible = false; // hide ID column
                        }

                        DataRow dr = dt.NewRow();
                        dr[0] = sql.ExecuteScalar("select seq from sqlite_sequence where name='avgHours';");
                        dr[1] = dayOfWeek;
                        dr[2] = clockIn;
                        dr[3] = clockOut;

                        // TODO find out why this event gets deregistered and re-registered (and possibly do whatever it does directly to make it less confusing)
                        AvgHoursGridView.RowStateChanged -= new DataGridViewRowStateChangedEventHandler(AvgHoursGridView_RowStateChanged);

                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                        AvgHoursGridView.ClearSelection();

                        AvgHoursGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(AvgHoursGridView_RowStateChanged);
                    }
                }
            } catch (Exception err) {
                MessageBox.Show(this, "There was an error while trying to save the entry.\n\n" + err.Message, "Save Avg Hours Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            try {
                string toDeleteId = AvgHoursGridView.SelectedRows[0].Cells[0].Value.ToString();
                int rowId = AvgHoursGridView.SelectedRows[0].Index;

                if (sql.Delete("avgHours", "id=" + toDeleteId)) {
                    DisableUI();
                    AvgHoursGridView.RowStateChanged -= new DataGridViewRowStateChangedEventHandler(AvgHoursGridView_RowStateChanged);
                    AvgHoursGridView.Rows.RemoveAt(rowId);
                    AvgHoursGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(AvgHoursGridView_RowStateChanged);
                    SetAddButton();
                }
            } catch (Exception err) {
                MessageBox.Show(this, "There was an error while trying to delete the entry.\n\n" + err.Message, "Delete Avg Hours Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            SetAddButton();
        }

        private void SetAddButton() {
            AvgHoursGridView.ClearSelection();
            DeleteButton.Enabled = false;
            ClearButton.Enabled = false;
            ClockInTimePicker.Enabled = true;
            ClockOutTimePicker.Enabled = true;
            DayOfWeekComboBox.Enabled = true;
            SaveButton.Enabled = true;
            SaveButton.Text = "Add";
        }
    }
}
