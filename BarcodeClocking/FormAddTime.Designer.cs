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
    partial class FormAddTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTime));
            DateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            LabelTip = new System.Windows.Forms.Label();
            LabelIn = new System.Windows.Forms.Label();
            LabelOut = new System.Windows.Forms.Label();
            DateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            ButtonAdd = new System.Windows.Forms.Button();
            TextBoxCardID = new System.Windows.Forms.TextBox();
            LabelID = new System.Windows.Forms.Label();
            datePicker = new System.Windows.Forms.DateTimePicker();
            DateLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // DateTimePickerIn
            // 
            DateTimePickerIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            DateTimePickerIn.CustomFormat = "h:mm:ss tt";
            DateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            DateTimePickerIn.Location = new System.Drawing.Point(255, 95);
            DateTimePickerIn.Margin = new System.Windows.Forms.Padding(2);
            DateTimePickerIn.Name = "DateTimePickerIn";
            DateTimePickerIn.ShowUpDown = true;
            DateTimePickerIn.Size = new System.Drawing.Size(109, 20);
            DateTimePickerIn.TabIndex = 2;
            DateTimePickerIn.ValueChanged += new System.EventHandler(DateTimePickerIn_ValueChanged);
            // 
            // LabelTip
            // 
            LabelTip.Location = new System.Drawing.Point(9, 7);
            LabelTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelTip.Name = "LabelTip";
            LabelTip.Size = new System.Drawing.Size(355, 33);
            LabelTip.TabIndex = 2;
            LabelTip.Text = "Scan your card or enter your Student ID, then set the clock-in and clock-out time" +
    "s. Click the \"Add Time\" button to log the time.";
            // 
            // LabelIn
            // 
            LabelIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            LabelIn.AutoSize = true;
            LabelIn.Location = new System.Drawing.Point(177, 98);
            LabelIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelIn.Name = "LabelIn";
            LabelIn.Size = new System.Drawing.Size(75, 13);
            LabelIn.TabIndex = 3;
            LabelIn.Text = "Clock-In Time:";
            // 
            // LabelOut
            // 
            LabelOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            LabelOut.AutoSize = true;
            LabelOut.Location = new System.Drawing.Point(170, 122);
            LabelOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelOut.Name = "LabelOut";
            LabelOut.Size = new System.Drawing.Size(83, 13);
            LabelOut.TabIndex = 5;
            LabelOut.Text = "Clock-Out Time:";
            // 
            // DateTimePickerOut
            // 
            DateTimePickerOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            DateTimePickerOut.CustomFormat = "h:mm:ss tt";
            DateTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            DateTimePickerOut.Location = new System.Drawing.Point(255, 119);
            DateTimePickerOut.Margin = new System.Windows.Forms.Padding(2);
            DateTimePickerOut.Name = "DateTimePickerOut";
            DateTimePickerOut.ShowUpDown = true;
            DateTimePickerOut.Size = new System.Drawing.Size(110, 20);
            DateTimePickerOut.TabIndex = 3;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonAdd.Location = new System.Drawing.Point(255, 141);
            ButtonAdd.Margin = new System.Windows.Forms.Padding(2);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new System.Drawing.Size(110, 22);
            ButtonAdd.TabIndex = 4;
            ButtonAdd.Text = "Add Time && Close";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += new System.EventHandler(ButtonAdd_Click);
            // 
            // TextBoxCardID
            // 
            TextBoxCardID.AcceptsReturn = true;
            TextBoxCardID.Location = new System.Drawing.Point(95, 43);
            TextBoxCardID.Margin = new System.Windows.Forms.Padding(2);
            TextBoxCardID.Name = "TextBoxCardID";
            TextBoxCardID.Size = new System.Drawing.Size(270, 20);
            TextBoxCardID.TabIndex = 1;
            TextBoxCardID.KeyDown += new System.Windows.Forms.KeyEventHandler(TextBoxID_KeyDown);
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new System.Drawing.Point(9, 43);
            LabelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelID.Name = "LabelID";
            LabelID.Size = new System.Drawing.Size(88, 13);
            LabelID.TabIndex = 8;
            LabelID.Text = "Card/Student ID:";
            // 
            // datePicker
            // 
            datePicker.Location = new System.Drawing.Point(165, 68);
            datePicker.Name = "datePicker";
            datePicker.Size = new System.Drawing.Size(200, 20);
            datePicker.TabIndex = 9;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new System.Drawing.Point(132, 71);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new System.Drawing.Size(33, 13);
            DateLabel.TabIndex = 10;
            DateLabel.Text = "Date:";
            // 
            // FormAddTime
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(369, 169);
            Controls.Add(DateLabel);
            Controls.Add(datePicker);
            Controls.Add(LabelID);
            Controls.Add(TextBoxCardID);
            Controls.Add(ButtonAdd);
            Controls.Add(LabelOut);
            Controls.Add(DateTimePickerOut);
            Controls.Add(LabelIn);
            Controls.Add(LabelTip);
            Controls.Add(DateTimePickerIn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddTime";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "FormAddTime";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerIn;
        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.Label LabelIn;
        private System.Windows.Forms.Label LabelOut;
        private System.Windows.Forms.DateTimePicker DateTimePickerOut;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxCardID;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}