﻿// Copyright © 2015 Lower Columbia College Computer Science Club

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
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace BarcodeClocking {
    public partial class FormEditPast : Form {
        // vars
        private char[] invalidChars;
        private SQLiteDatabase sql = new SQLiteDatabase();
        private DataTable dt;

        public FormEditPast() {
            InitializeComponent();

            // set month and year selection
            ComboBoxMonth.SelectedIndex = DateTime.Today.Month - 1;
            NumericUpDownYear.Value = DateTime.Today.Year;

            // get list of invalid chars for system, excluding backspace
            List<char> tempList = Path.GetInvalidFileNameChars().ToList();
            tempList.Remove('\b');
            invalidChars = tempList.ToArray();

        }

        private void ButtonLoad_Click(object sender, EventArgs e) {
            if (TextBoxCardID.Text != "") {
                // change gui
                ButtonLoad.Text = "Loading Times...";
                ButtonLoad.Enabled = false;
                TextBoxCardID.Enabled = false;
                ComboBoxMonth.Enabled = false;
                NumericUpDownYear.Enabled = false;
                DataGridViewTimes.Rows.Clear();

                // get month beginning and end
                DateTime monthStart = new DateTime((int)NumericUpDownYear.Value, ComboBoxMonth.SelectedIndex + 1, 1);
                DateTime monthEnd = monthStart.AddMonths(1);

                // check if this is the card we're looking for
                if (Helper.EmployeeExists(TextBoxCardID.Text, sql)) {

                    try {
                        dt = sql.GetDataTable("select strftime('%m/%d/%Y %H:%M:%S', clockIn) as clockIn,"
                            + " strftime('%m/%d/%Y %H:%M:%S', clockOut) as clockOut, id "
                            + " from timeStamps where employeeID=" + TextBoxCardID.Text.Trim()
                            + " and clockOut<>'' "
                            + " and cast(strftime('%m', clockIn) as integer) = " + (int)(ComboBoxMonth.SelectedIndex + 1)
                            + " and cast(strftime('%Y', clockIn) as integer) = " + (int)NumericUpDownYear.Value + ";");

                        if (dt.Rows.Count > 0) {

                            DataGridViewTimes.DataSource = dt;

                            foreach (DataGridViewRow entry in DataGridViewTimes.Rows) {
                                entry.Cells[0].Value = DateTime.Parse(entry.Cells[0].Value.ToString()).ToString(StringFormats.timeStampFormat);
                                entry.Cells[1].Value = DateTime.Parse(entry.Cells[1].Value.ToString()).ToString(StringFormats.timeStampFormat);

                            }

                            DataGridViewTimes.Sort(DataGridViewTimes.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

                            DataGridViewTimes.ClearSelection();

                            //Hide id column, used to determine which entry to update/remove 
                            DataGridViewTimes.Columns[2].Visible = false;

                            DataGridViewTimes.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(DataGridViewTimes_RowStateChanged);

                        } else {
                            // notify user no times for specified month
                            MessageBox.Show(this, "It looks like there isn't any time you logged in the selected month. Are you sure the year and month selections are correct?", "No Times", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // reset gui
                            ResetUI();
                        }

                    } catch (Exception err) {
                        MessageBox.Show(this, "There was an error while trying to load your clocked times.\n\n" + err.Message, "Times Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        DataGridViewTimes.DataSource = null;

                        // enable controls
                        TextBoxCardID.Enabled = true;
                        ComboBoxMonth.Enabled = true;
                        NumericUpDownYear.Enabled = true;
                        ButtonLoad.Enabled = true;
                        ButtonSave.Enabled = false;
                        DeleteButton.Enabled = false;
                    }

                } else {
                    MessageBox.Show(this, "The card you entered wasn't found. Are you sure you typed it in correctly?", "Card Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // reset gui
                    ResetUI();
                }


                // change 'status'
                ButtonLoad.Text = "Load Times";
            }
        }

        private void DataGridViewTimes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
            if (e.StateChanged == DataGridViewElementStates.Selected && e.Row.Selected) {
                DisableTimePickers();
                datePicker.Value = DateTime.Parse(e.Row.Cells[0].Value.ToString());
                clockInTimePicker.Value = DateTime.Parse(e.Row.Cells[0].Value.ToString());
                clockOutTimePicker.Value = DateTime.Parse(e.Row.Cells[1].Value.ToString());

                // enable saving
                EnableUI();
                EnableTimePickers();
            }

        }

        private void ButtonReset_Click(object sender, EventArgs e) {
            // make sure nothing needs to be saved
            if (ButtonSave.Enabled) {
                // switch on user choice
                switch (MessageBox.Show(this, "There are unsaved changes. Would you like to save them before resetting this window?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk)) {
                    case DialogResult.Yes:
                        ButtonSave_Click(sender, e);
                        break;
                    case DialogResult.Cancel: return;
                }

            }

            // reset gui
            TextBoxCardID.Clear();
            TextBoxCardID.Enabled = true;
            ComboBoxMonth.SelectedIndex = DateTime.Today.Month - 1;
            ComboBoxMonth.Enabled = true;
            NumericUpDownYear.Value = (decimal)DateTime.Today.Year;
            NumericUpDownYear.Enabled = true;
            DataGridViewTimes.ClearSelection();
            DataGridViewTimes.RowStateChanged -= new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(DataGridViewTimes_RowStateChanged);
            DataGridViewTimes.DataSource = null;
            DisableUI();
            DisableTimePickers();
            ButtonLoad.Enabled = true;

        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            if (DataGridViewTimes.SelectedRows.Count > 0) {
                // vars
                string timeStampId = DataGridViewTimes.SelectedRows[0].Cells[2].Value.ToString();

                try {
                    //Make sure clockOut date is the same as clockIn date
                    clockInTimePicker.Value = datePicker.Value.Date + clockInTimePicker.Value.TimeOfDay;
                    clockOutTimePicker.Value = datePicker.Value.Date + clockOutTimePicker.Value.TimeOfDay;

                    Dictionary<String, String> data = new Dictionary<String, String>();
                    data.Add("clockIn", clockInTimePicker.Value.ToString(StringFormats.sqlTimeFormat));
                    data.Add("clockOut", clockOutTimePicker.Value.ToString(StringFormats.sqlTimeFormat));

                    if (sql.Update("timeStamps", data, String.Format("timeStamps.id = {0}", timeStampId))) {
                        DataGridViewTimes.SelectedRows[0].Cells[0].Value = clockInTimePicker.Value.ToString(StringFormats.timeStampFormat);
                        DataGridViewTimes.SelectedRows[0].Cells[1].Value = clockOutTimePicker.Value.ToString(StringFormats.timeStampFormat);
                        DataGridViewTimes.Sort(DataGridViewTimes.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    }
                    // disable duplicate saving
                    DisableUI();
                    DisableTimePickers();
                } catch (Exception err) {
                    MessageBox.Show(this, "There was an error while trying to save your changes.\n\n" + err.Message, "Time Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormEditPast_FormClosing(object sender, FormClosingEventArgs e) {
            // make sure nothing needs to be saved
            if (ButtonSave.Enabled) {
                // switch on user choice
                switch (MessageBox.Show(this, "There are unsaved changes. Would you like to save them before closing?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk)) {
                    case DialogResult.Yes:
                        ButtonSave_Click(sender, e);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            try {
                string toDeleteId = DataGridViewTimes.SelectedRows[0].Cells[2].Value.ToString();
                int rowId = DataGridViewTimes.SelectedRows[0].Index;

                if (sql.Delete("timeStamps", "id=" + toDeleteId)) {
                    DataGridViewTimes.RowStateChanged -= new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(DataGridViewTimes_RowStateChanged);
                    DataGridViewTimes.Rows.RemoveAt(rowId);
                    DataGridViewTimes.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(DataGridViewTimes_RowStateChanged);

                    DisableUI();
                    DisableTimePickers();
                }
            } catch (Exception err) {
                MessageBox.Show(this, "There was an error while trying to delete the entry.\n\n" + err.Message, "Delete Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clockInTimePicker_ValueChanged(object sender, System.EventArgs e) {
            try {
                clockInTimePicker.Value = datePicker.Value.Date + clockInTimePicker.Value.TimeOfDay;

                clockOutTimePicker.MinDate = clockInTimePicker.Value;
                clockOutTimePicker.Value = datePicker.Value.Date + clockOutTimePicker.Value.TimeOfDay;
                clockOutTimePicker.MaxDate = datePicker.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            } catch (System.Exception ex) {
                MessageBox.Show(this, "There was an error while trying to edit your time log. Did you log over 24 hours?\n\nReseting to Clock-In time.\n\n" + ex.Message, "Time Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                clockOutTimePicker.Value = clockInTimePicker.Value;
            }
        }


        private void DisableTimePickers() {
            clockInTimePicker.ValueChanged -= new System.EventHandler(clockInTimePicker_ValueChanged);
            clockInTimePicker.Enabled = false;
            clockOutTimePicker.Enabled = false;
        }

        private void EnableTimePickers() {
            clockInTimePicker.ValueChanged += new System.EventHandler(clockInTimePicker_ValueChanged);
            clockInTimePicker.Enabled = true;
            clockOutTimePicker.Enabled = true;
        }

        private void DisableUI() {
            DataGridViewTimes.ClearSelection();
            clockInTimePicker.Enabled = false;
            clockOutTimePicker.Enabled = false;
            datePicker.Enabled = false;
            ButtonSave.Enabled = false;
            DeleteButton.Enabled = false;

        }

        private void EnableUI() {
            clockInTimePicker.Enabled = true;
            clockOutTimePicker.Enabled = true;
            datePicker.Enabled = true;
            ButtonSave.Enabled = true;
            DeleteButton.Enabled = true;

        }

        private void ResetUI() {
            TextBoxCardID.Enabled = true;
            ComboBoxMonth.Enabled = true;
            NumericUpDownYear.Enabled = true;
            DataGridViewTimes.DataSource = null;
            ButtonLoad.Enabled = true;
            ButtonSave.Enabled = false;

        }
    }

}