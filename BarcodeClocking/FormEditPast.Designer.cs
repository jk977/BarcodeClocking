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

namespace BarcodeClocking
{
    partial class FormEditPast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPast));
            LabelHint = new System.Windows.Forms.Label();
            LabelMonth = new System.Windows.Forms.Label();
            ComboBoxMonth = new System.Windows.Forms.ComboBox();
            DataGridViewTimes = new System.Windows.Forms.DataGridView();
            ColumnClockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnClockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ButtonLoad = new System.Windows.Forms.Button();
            TextBoxCardID = new System.Windows.Forms.TextBox();
            LabelCardID = new System.Windows.Forms.Label();
            NumericUpDownYear = new System.Windows.Forms.NumericUpDown();
            LabelYear = new System.Windows.Forms.Label();
            ButtonSave = new System.Windows.Forms.Button();
            ButtonReset = new System.Windows.Forms.Button();
            datePicker = new System.Windows.Forms.DateTimePicker();
            clockInTimePicker = new System.Windows.Forms.DateTimePicker();
            clockOutTimePicker = new System.Windows.Forms.DateTimePicker();
            dateLabel = new System.Windows.Forms.Label();
            clockInLabel = new System.Windows.Forms.Label();
            clockOutLabel = new System.Windows.Forms.Label();
            DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(DataGridViewTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(NumericUpDownYear)).BeginInit();
            SuspendLayout();
            // 
            // LabelHint
            // 
            LabelHint.Location = new System.Drawing.Point(9, 7);
            LabelHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelHint.Name = "LabelHint";
            LabelHint.Size = new System.Drawing.Size(406, 54);
            LabelHint.TabIndex = 0;
            LabelHint.Text = "Scan your card or enter your Student ID to pull up logged times within the respec" +
    "tive month. ";
            // 
            // LabelMonth
            // 
            LabelMonth.AutoSize = true;
            LabelMonth.Location = new System.Drawing.Point(9, 89);
            LabelMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelMonth.Name = "LabelMonth";
            LabelMonth.Size = new System.Drawing.Size(40, 13);
            LabelMonth.TabIndex = 5;
            LabelMonth.Text = "Month:";
            // 
            // ComboBoxMonth
            // 
            ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboBoxMonth.FormattingEnabled = true;
            ComboBoxMonth.ItemHeight = 13;
            ComboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            ComboBoxMonth.Location = new System.Drawing.Point(98, 87);
            ComboBoxMonth.Margin = new System.Windows.Forms.Padding(2);
            ComboBoxMonth.MaxDropDownItems = 12;
            ComboBoxMonth.Name = "ComboBoxMonth";
            ComboBoxMonth.Size = new System.Drawing.Size(200, 21);
            ComboBoxMonth.TabIndex = 2;
            // 
            // DataGridViewTimes
            // 
            DataGridViewTimes.AllowUserToAddRows = false;
            DataGridViewTimes.AllowUserToResizeColumns = false;
            DataGridViewTimes.AllowUserToResizeRows = false;
            DataGridViewTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTimes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            DataGridViewTimes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            DataGridViewTimes.Location = new System.Drawing.Point(9, 134);
            DataGridViewTimes.Margin = new System.Windows.Forms.Padding(2);
            DataGridViewTimes.MultiSelect = false;
            DataGridViewTimes.Name = "DataGridViewTimes";
            DataGridViewTimes.ReadOnly = true;
            DataGridViewTimes.RowHeadersVisible = false;
            DataGridViewTimes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            DataGridViewTimes.RowTemplate.Height = 24;
            DataGridViewTimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            DataGridViewTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DataGridViewTimes.Size = new System.Drawing.Size(406, 155);
            DataGridViewTimes.TabIndex = 5;
            DataGridViewTimes.VirtualMode = true;
            // 
            // ColumnClockIn
            // 
            ColumnClockIn.Name = "ColumnClockIn";
            // 
            // ColumnClockOut
            // 
            ColumnClockOut.Name = "ColumnClockOut";
            // 
            // ButtonLoad
            // 
            ButtonLoad.Location = new System.Drawing.Point(302, 70);
            ButtonLoad.Margin = new System.Windows.Forms.Padding(2);
            ButtonLoad.Name = "ButtonLoad";
            ButtonLoad.Size = new System.Drawing.Size(112, 22);
            ButtonLoad.TabIndex = 4;
            ButtonLoad.Text = "Load Times";
            ButtonLoad.UseVisualStyleBackColor = true;
            ButtonLoad.Click += new System.EventHandler(ButtonLoad_Click);
            // 
            // TextBoxCardID
            // 
            TextBoxCardID.Location = new System.Drawing.Point(98, 64);
            TextBoxCardID.Margin = new System.Windows.Forms.Padding(2);
            TextBoxCardID.Name = "TextBoxCardID";
            TextBoxCardID.Size = new System.Drawing.Size(200, 20);
            TextBoxCardID.TabIndex = 1;
            // 
            // LabelCardID
            // 
            LabelCardID.AutoSize = true;
            LabelCardID.Location = new System.Drawing.Point(9, 67);
            LabelCardID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelCardID.Name = "LabelCardID";
            LabelCardID.Size = new System.Drawing.Size(88, 13);
            LabelCardID.TabIndex = 11;
            LabelCardID.Text = "Card/Student ID:";
            // 
            // NumericUpDownYear
            // 
            NumericUpDownYear.Location = new System.Drawing.Point(98, 111);
            NumericUpDownYear.Margin = new System.Windows.Forms.Padding(2);
            NumericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            NumericUpDownYear.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            NumericUpDownYear.Name = "NumericUpDownYear";
            NumericUpDownYear.Size = new System.Drawing.Size(200, 20);
            NumericUpDownYear.TabIndex = 3;
            NumericUpDownYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // LabelYear
            // 
            LabelYear.AutoSize = true;
            LabelYear.Location = new System.Drawing.Point(9, 113);
            LabelYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelYear.Name = "LabelYear";
            LabelYear.Size = new System.Drawing.Size(32, 13);
            LabelYear.TabIndex = 13;
            LabelYear.Text = "Year:";
            // 
            // ButtonSave
            // 
            ButtonSave.Enabled = false;
            ButtonSave.Location = new System.Drawing.Point(344, 400);
            ButtonSave.Margin = new System.Windows.Forms.Padding(2);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new System.Drawing.Size(70, 23);
            ButtonSave.TabIndex = 6;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += new System.EventHandler(ButtonSave_Click);
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new System.Drawing.Point(302, 102);
            ButtonReset.Margin = new System.Windows.Forms.Padding(2);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new System.Drawing.Size(112, 22);
            ButtonReset.TabIndex = 7;
            ButtonReset.Text = "Reset";
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "MM/dd/yy";
            datePicker.Enabled = false;
            datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            datePicker.Location = new System.Drawing.Point(315, 313);
            datePicker.Name = "datePicker";
            datePicker.Size = new System.Drawing.Size(99, 20);
            datePicker.TabIndex = 14;
            // 
            // clockInTimePicker
            // 
            clockInTimePicker.CustomFormat = "";
            clockInTimePicker.Enabled = false;
            clockInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            clockInTimePicker.Location = new System.Drawing.Point(326, 340);
            clockInTimePicker.Name = "clockInTimePicker";
            clockInTimePicker.ShowUpDown = true;
            clockInTimePicker.Size = new System.Drawing.Size(87, 20);
            clockInTimePicker.TabIndex = 15;
            // 
            // clockOutTimePicker
            // 
            clockOutTimePicker.Enabled = false;
            clockOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            clockOutTimePicker.Location = new System.Drawing.Point(326, 369);
            clockOutTimePicker.Name = "clockOutTimePicker";
            clockOutTimePicker.ShowUpDown = true;
            clockOutTimePicker.Size = new System.Drawing.Size(87, 20);
            clockOutTimePicker.TabIndex = 16;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(270, 316);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 17;
            dateLabel.Text = "Date:";
            // 
            // clockInLabel
            // 
            clockInLabel.AutoSize = true;
            clockInLabel.Location = new System.Drawing.Point(269, 343);
            clockInLabel.Name = "clockInLabel";
            clockInLabel.Size = new System.Drawing.Size(49, 13);
            clockInLabel.TabIndex = 18;
            clockInLabel.Text = "Clock In:";
            // 
            // clockOutLabel
            // 
            clockOutLabel.AutoSize = true;
            clockOutLabel.Location = new System.Drawing.Point(268, 372);
            clockOutLabel.Name = "clockOutLabel";
            clockOutLabel.Size = new System.Drawing.Size(57, 13);
            clockOutLabel.TabIndex = 19;
            clockOutLabel.Text = "Clock Out:";
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new System.Drawing.Point(271, 400);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(68, 23);
            DeleteButton.TabIndex = 20;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += new System.EventHandler(DeleteButton_Click);
            // 
            // FormEditPast
            // 
            AcceptButton = ButtonLoad;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(425, 432);
            Controls.Add(DeleteButton);
            Controls.Add(clockOutLabel);
            Controls.Add(clockInLabel);
            Controls.Add(dateLabel);
            Controls.Add(clockOutTimePicker);
            Controls.Add(clockInTimePicker);
            Controls.Add(datePicker);
            Controls.Add(ButtonReset);
            Controls.Add(ButtonSave);
            Controls.Add(LabelYear);
            Controls.Add(NumericUpDownYear);
            Controls.Add(TextBoxCardID);
            Controls.Add(LabelCardID);
            Controls.Add(ButtonLoad);
            Controls.Add(DataGridViewTimes);
            Controls.Add(LabelMonth);
            Controls.Add(ComboBoxMonth);
            Controls.Add(LabelHint);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(441, 470);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(441, 470);
            Name = "FormEditPast";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Edit Past Time";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormEditPast_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(DataGridViewTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(NumericUpDownYear)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHint;
        private System.Windows.Forms.Label LabelMonth;
        private System.Windows.Forms.ComboBox ComboBoxMonth;
        private System.Windows.Forms.DataGridView DataGridViewTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClockOut;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.TextBox TextBoxCardID;
        private System.Windows.Forms.Label LabelCardID;
        private System.Windows.Forms.NumericUpDown NumericUpDownYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker clockInTimePicker;
        private System.Windows.Forms.DateTimePicker clockOutTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label clockInLabel;
        private System.Windows.Forms.Label clockOutLabel;
        private System.Windows.Forms.Button DeleteButton;
    }
}