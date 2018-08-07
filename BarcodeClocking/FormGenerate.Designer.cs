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
    partial class FormGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerate));
            label1 = new System.Windows.Forms.Label();
            LabelCardID = new System.Windows.Forms.Label();
            TextBoxCardID = new System.Windows.Forms.TextBox();
            ComboBoxMonth = new System.Windows.Forms.ComboBox();
            LabelMonth = new System.Windows.Forms.Label();
            ButtonGenerate = new System.Windows.Forms.Button();
            NumericUpDownYear = new System.Windows.Forms.NumericUpDown();
            LabelYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(NumericUpDownYear)).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(358, 40);
            label1.TabIndex = 0;
            label1.Text = "Scan your card or type your Student ID and press enter to generate you Time Sheet" +
    ".";
            // 
            // LabelCardID
            // 
            LabelCardID.AutoSize = true;
            LabelCardID.Location = new System.Drawing.Point(12, 55);
            LabelCardID.Name = "LabelCardID";
            LabelCardID.Size = new System.Drawing.Size(112, 17);
            LabelCardID.TabIndex = 1;
            LabelCardID.Text = "Card/Student ID:";
            // 
            // TextBoxCardID
            // 
            TextBoxCardID.Location = new System.Drawing.Point(130, 52);
            TextBoxCardID.Name = "TextBoxCardID";
            TextBoxCardID.Size = new System.Drawing.Size(240, 22);
            TextBoxCardID.TabIndex = 1;
            TextBoxCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Helper.OnKeyPress);
            // 
            // ComboBoxMonth
            // 
            ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboBoxMonth.FormattingEnabled = true;
            ComboBoxMonth.ItemHeight = 16;
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
            ComboBoxMonth.Location = new System.Drawing.Point(130, 80);
            ComboBoxMonth.MaxDropDownItems = 12;
            ComboBoxMonth.Name = "ComboBoxMonth";
            ComboBoxMonth.Size = new System.Drawing.Size(240, 24);
            ComboBoxMonth.TabIndex = 2;
            // 
            // LabelMonth
            // 
            LabelMonth.AutoSize = true;
            LabelMonth.Location = new System.Drawing.Point(12, 83);
            LabelMonth.Name = "LabelMonth";
            LabelMonth.Size = new System.Drawing.Size(51, 17);
            LabelMonth.TabIndex = 3;
            LabelMonth.Text = "Month:";
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonGenerate.Location = new System.Drawing.Point(0, 138);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new System.Drawing.Size(382, 27);
            ButtonGenerate.TabIndex = 4;
            ButtonGenerate.Text = "Generate Time Sheet";
            ButtonGenerate.UseVisualStyleBackColor = true;
            ButtonGenerate.Click += new System.EventHandler(ButtonGenerate_Click);
            // 
            // NumericUpDownYear
            // 
            NumericUpDownYear.Location = new System.Drawing.Point(130, 110);
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
            NumericUpDownYear.Size = new System.Drawing.Size(240, 22);
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
            LabelYear.Location = new System.Drawing.Point(12, 112);
            LabelYear.Name = "LabelYear";
            LabelYear.Size = new System.Drawing.Size(42, 17);
            LabelYear.TabIndex = 5;
            LabelYear.Text = "Year:";
            // 
            // FormGenerate
            // 
            AcceptButton = ButtonGenerate;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(382, 165);
            Controls.Add(LabelYear);
            Controls.Add(NumericUpDownYear);
            Controls.Add(ButtonGenerate);
            Controls.Add(LabelMonth);
            Controls.Add(ComboBoxMonth);
            Controls.Add(TextBoxCardID);
            Controls.Add(LabelCardID);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(400, 220);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(400, 189);
            Name = "FormGenerate";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Generate Time Sheet";
            ((System.ComponentModel.ISupportInitialize)(NumericUpDownYear)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCardID;
        private System.Windows.Forms.TextBox TextBoxCardID;
        private System.Windows.Forms.ComboBox ComboBoxMonth;
        private System.Windows.Forms.Label LabelMonth;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.NumericUpDown NumericUpDownYear;
        private System.Windows.Forms.Label LabelYear;
    }
}