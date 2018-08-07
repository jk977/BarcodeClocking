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
    partial class FormRemoveCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemoveCard));
            LabelTip = new System.Windows.Forms.Label();
            TextBoxCardID = new System.Windows.Forms.TextBox();
            LabelCardID = new System.Windows.Forms.Label();
            ButtonRemove = new System.Windows.Forms.Button();
            CheckBoxDelTimeLog = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // LabelTip
            // 
            LabelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelTip.Location = new System.Drawing.Point(12, 9);
            LabelTip.Name = "LabelTip";
            LabelTip.Size = new System.Drawing.Size(358, 37);
            LabelTip.TabIndex = 7;
            LabelTip.Text = "Scan your card to easily fill in the text box below. Leading and trailing spaces " +
    "are removed.";
            // 
            // TextBoxCardID
            // 
            TextBoxCardID.Location = new System.Drawing.Point(130, 49);
            TextBoxCardID.Name = "TextBoxCardID";
            TextBoxCardID.Size = new System.Drawing.Size(240, 22);
            TextBoxCardID.TabIndex = 1;
            TextBoxCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Helper.OnKeyPress);
            // 
            // LabelCardID
            // 
            LabelCardID.AutoSize = true;
            LabelCardID.Location = new System.Drawing.Point(12, 52);
            LabelCardID.Name = "LabelCardID";
            LabelCardID.Size = new System.Drawing.Size(112, 17);
            LabelCardID.TabIndex = 9;
            LabelCardID.Text = "Card/Student ID:";
            // 
            // ButtonRemove
            // 
            ButtonRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonRemove.Location = new System.Drawing.Point(0, 125);
            ButtonRemove.Name = "ButtonRemove";
            ButtonRemove.Size = new System.Drawing.Size(382, 27);
            ButtonRemove.TabIndex = 2;
            ButtonRemove.Text = "Remove Card";
            ButtonRemove.UseVisualStyleBackColor = true;
            ButtonRemove.Click += new System.EventHandler(ButtonRemove_Click);
            // 
            // CheckBoxDelTimeLog
            // 
            CheckBoxDelTimeLog.AutoSize = true;
            CheckBoxDelTimeLog.Checked = true;
            CheckBoxDelTimeLog.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckBoxDelTimeLog.Location = new System.Drawing.Point(12, 77);
            CheckBoxDelTimeLog.Name = "CheckBoxDelTimeLog";
            CheckBoxDelTimeLog.Size = new System.Drawing.Size(328, 38);
            CheckBoxDelTimeLog.TabIndex = 10;
            CheckBoxDelTimeLog.Text = "Also delete the respective time log file\r\n(Uncheck if you plan on adding this car" +
    "d again)";
            CheckBoxDelTimeLog.UseVisualStyleBackColor = true;
            // 
            // FormRemoveCard
            // 
            AcceptButton = ButtonRemove;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(382, 152);
            Controls.Add(CheckBoxDelTimeLog);
            Controls.Add(ButtonRemove);
            Controls.Add(TextBoxCardID);
            Controls.Add(LabelCardID);
            Controls.Add(LabelTip);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(400, 197);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(400, 197);
            Name = "FormRemoveCard";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Remove Card";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.TextBox TextBoxCardID;
        private System.Windows.Forms.Label LabelCardID;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.CheckBox CheckBoxDelTimeLog;
    }
}