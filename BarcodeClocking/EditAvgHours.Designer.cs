namespace BarcodeClocking
{
    partial class EditAvgHours
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
            AvgHoursGridView = new System.Windows.Forms.DataGridView();
            DayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            DeleteButton = new System.Windows.Forms.Button();
            ClearButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            ClockInTimePicker = new System.Windows.Forms.DateTimePicker();
            ClockOutTimePicker = new System.Windows.Forms.DateTimePicker();
            DescLabel = new System.Windows.Forms.Label();
            TextBoxCardID = new System.Windows.Forms.TextBox();
            LoadButton = new System.Windows.Forms.Button();
            IdLabel = new System.Windows.Forms.Label();
            ClockInLabel = new System.Windows.Forms.Label();
            ClockOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(AvgHoursGridView)).BeginInit();
            SuspendLayout();
            // 
            // AvgHoursGridView
            // 
            AvgHoursGridView.AllowUserToAddRows = false;
            AvgHoursGridView.AllowUserToResizeColumns = false;
            AvgHoursGridView.AllowUserToResizeRows = false;
            AvgHoursGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            AvgHoursGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AvgHoursGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            AvgHoursGridView.Location = new System.Drawing.Point(12, 102);
            AvgHoursGridView.MultiSelect = false;
            AvgHoursGridView.Name = "AvgHoursGridView";
            AvgHoursGridView.ReadOnly = true;
            AvgHoursGridView.RowHeadersVisible = false;
            AvgHoursGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            AvgHoursGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            AvgHoursGridView.Size = new System.Drawing.Size(349, 150);
            AvgHoursGridView.TabIndex = 3;
            AvgHoursGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(AvgHoursGridView_CellFormatting);
            // 
            // DayOfWeekComboBox
            // 
            DayOfWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DayOfWeekComboBox.FormattingEnabled = true;
            DayOfWeekComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            DayOfWeekComboBox.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            DayOfWeekComboBox.Location = new System.Drawing.Point(181, 258);
            DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            DayOfWeekComboBox.Size = new System.Drawing.Size(84, 21);
            DayOfWeekComboBox.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new System.Drawing.Point(205, 340);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(75, 23);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += new System.EventHandler(DeleteButton_Click);
            // 
            // ClearButton
            // 
            ClearButton.Location = new System.Drawing.Point(286, 311);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new System.Drawing.Size(75, 23);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += new System.EventHandler(ClearButton_Click);
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(286, 340);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += new System.EventHandler(SaveButton_Click);
            // 
            // ClockInTimePicker
            // 
            ClockInTimePicker.CustomFormat = "h:mm tt";
            ClockInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            ClockInTimePicker.Location = new System.Drawing.Point(286, 258);
            ClockInTimePicker.Name = "ClockInTimePicker";
            ClockInTimePicker.ShowUpDown = true;
            ClockInTimePicker.Size = new System.Drawing.Size(74, 20);
            ClockInTimePicker.TabIndex = 5;
            // 
            // ClockOutTimePicker
            // 
            ClockOutTimePicker.CustomFormat = "h:mm tt";
            ClockOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            ClockOutTimePicker.Location = new System.Drawing.Point(286, 285);
            ClockOutTimePicker.Name = "ClockOutTimePicker";
            ClockOutTimePicker.ShowUpDown = true;
            ClockOutTimePicker.Size = new System.Drawing.Size(75, 20);
            ClockOutTimePicker.TabIndex = 6;
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.Location = new System.Drawing.Point(6, 11);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new System.Drawing.Size(362, 39);
            DescLabel.TabIndex = 7;
            DescLabel.Text = "\"Average Hours\" are used to determine when you should have clocked out\r\n if you f" +
    "orgot to,or automatically fill in future dates when generating \r\ntime sheets.";
            // 
            // TextBoxCardID
            // 
            TextBoxCardID.Location = new System.Drawing.Point(101, 76);
            TextBoxCardID.Name = "TextBoxCardID";
            TextBoxCardID.Size = new System.Drawing.Size(179, 20);
            TextBoxCardID.TabIndex = 0;
            TextBoxCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Helper.OnKeyPress);

            // 
            // LoadButton
            // 
            LoadButton.Location = new System.Drawing.Point(288, 74);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new System.Drawing.Size(75, 23);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += new System.EventHandler(LoadButton_Click);
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new System.Drawing.Point(34, 79);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new System.Drawing.Size(61, 13);
            IdLabel.TabIndex = 10;
            IdLabel.Text = "Student ID:";
            // 
            // ClockInLabel
            // 
            ClockInLabel.AutoSize = true;
            ClockInLabel.Location = new System.Drawing.Point(126, 261);
            ClockInLabel.Name = "ClockInLabel";
            ClockInLabel.Size = new System.Drawing.Size(49, 13);
            ClockInLabel.TabIndex = 11;
            ClockInLabel.Text = "Clock In:";
            // 
            // ClockOutLabel
            // 
            ClockOutLabel.AutoSize = true;
            ClockOutLabel.Location = new System.Drawing.Point(223, 288);
            ClockOutLabel.Name = "ClockOutLabel";
            ClockOutLabel.Size = new System.Drawing.Size(57, 13);
            ClockOutLabel.TabIndex = 12;
            ClockOutLabel.Text = "Clock Out:";
            // 
            // EditAvgHours
            // 
            AcceptButton = LoadButton;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(375, 372);
            Controls.Add(ClockOutLabel);
            Controls.Add(ClockInLabel);
            Controls.Add(IdLabel);
            Controls.Add(LoadButton);
            Controls.Add(TextBoxCardID);
            Controls.Add(DescLabel);
            Controls.Add(ClockOutTimePicker);
            Controls.Add(ClockInTimePicker);
            Controls.Add(SaveButton);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(DayOfWeekComboBox);
            Controls.Add(AvgHoursGridView);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAvgHours";
            Text = "Edit Avg Hours";
            ((System.ComponentModel.ISupportInitialize)(AvgHoursGridView)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AvgHoursGridView;
        private System.Windows.Forms.ComboBox DayOfWeekComboBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker ClockInTimePicker;
        private System.Windows.Forms.DateTimePicker ClockOutTimePicker;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.TextBox TextBoxCardID;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label ClockInLabel;
        private System.Windows.Forms.Label ClockOutLabel;
    }
}