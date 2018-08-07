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
    partial class FormAddCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCard));
            TextBoxFirstName = new System.Windows.Forms.TextBox();
            LabelFirstName = new System.Windows.Forms.Label();
            LabelLastName = new System.Windows.Forms.Label();
            TextBoxLastName = new System.Windows.Forms.TextBox();
            LabelCardID = new System.Windows.Forms.Label();
            TextBoxCardID = new System.Windows.Forms.TextBox();
            LabelTip = new System.Windows.Forms.Label();
            ButtonAdd = new System.Windows.Forms.Button();
            LabelSeparator = new System.Windows.Forms.Label();
            LabelMI = new System.Windows.Forms.Label();
            LabelHrRate = new System.Windows.Forms.Label();
            TextBoxMI = new System.Windows.Forms.TextBox();
            NumericUpDownHrRate = new System.Windows.Forms.NumericUpDown();
            LabelPosType = new System.Windows.Forms.Label();
            RadioButtonFWS = new System.Windows.Forms.RadioButton();
            RadioButtonSWS = new System.Windows.Forms.RadioButton();
            RadioButtonMST = new System.Windows.Forms.RadioButton();
            RadioButtonHED = new System.Windows.Forms.RadioButton();
            RadioButtonHelp = new System.Windows.Forms.RadioButton();
            RadioButtonTutor1 = new System.Windows.Forms.RadioButton();
            RadioButtonTutor2 = new System.Windows.Forms.RadioButton();
            RadioButtonTANF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(NumericUpDownHrRate)).BeginInit();
            SuspendLayout();
            // 
            // TextBoxFirstName
            // 
            TextBoxFirstName.Location = new System.Drawing.Point(130, 81);
            TextBoxFirstName.Name = "TextBoxFirstName";
            TextBoxFirstName.Size = new System.Drawing.Size(240, 22);
            TextBoxFirstName.TabIndex = 2;
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new System.Drawing.Point(12, 84);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new System.Drawing.Size(80, 17);
            LabelFirstName.TabIndex = 1;
            LabelFirstName.Text = "First Name:";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new System.Drawing.Point(12, 170);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new System.Drawing.Size(80, 17);
            LabelLastName.TabIndex = 2;
            LabelLastName.Text = "Last Name:";
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Location = new System.Drawing.Point(130, 167);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new System.Drawing.Size(240, 22);
            TextBoxLastName.TabIndex = 3;
            // 
            // LabelCardID
            // 
            LabelCardID.AutoSize = true;
            LabelCardID.Location = new System.Drawing.Point(12, 56);
            LabelCardID.Name = "LabelCardID";
            LabelCardID.Size = new System.Drawing.Size(112, 17);
            LabelCardID.TabIndex = 4;
            LabelCardID.Text = "Card/Student ID:";
            // 
            // TextBoxCardID
            // 
            TextBoxCardID.Location = new System.Drawing.Point(130, 53);
            TextBoxCardID.Name = "TextBoxCardID";
            TextBoxCardID.Size = new System.Drawing.Size(240, 22);
            TextBoxCardID.TabIndex = 1;
            TextBoxCardID.KeyDown += new System.Windows.Forms.KeyEventHandler(TextBoxCardID_KeyDown);
            TextBoxCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Helper.OnKeyPress);
            // 
            // LabelTip
            // 
            LabelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelTip.Location = new System.Drawing.Point(13, 13);
            LabelTip.Name = "LabelTip";
            LabelTip.Size = new System.Drawing.Size(357, 37);
            LabelTip.TabIndex = 6;
            LabelTip.Text = "Scan your card - before filling in other info - to easily set the Card ID.";
            // 
            // ButtonAdd
            // 
            ButtonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonAdd.Location = new System.Drawing.Point(0, 360);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new System.Drawing.Size(382, 27);
            ButtonAdd.TabIndex = 14;
            ButtonAdd.Text = "Add Card";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += new System.EventHandler(ButtonAdd_Click);
            // 
            // LabelSeparator
            // 
            LabelSeparator.Location = new System.Drawing.Point(12, 127);
            LabelSeparator.Name = "LabelSeparator";
            LabelSeparator.Size = new System.Drawing.Size(358, 37);
            LabelSeparator.TabIndex = 7;
            LabelSeparator.Text = "Optional Info\r\n(used to fill out respective fields in time sheet)";
            LabelSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMI
            // 
            LabelMI.AutoSize = true;
            LabelMI.Location = new System.Drawing.Point(12, 198);
            LabelMI.Name = "LabelMI";
            LabelMI.Size = new System.Drawing.Size(89, 17);
            LabelMI.TabIndex = 8;
            LabelMI.Text = "Middle Initial:";
            // 
            // LabelHrRate
            // 
            LabelHrRate.AutoSize = true;
            LabelHrRate.Location = new System.Drawing.Point(12, 225);
            LabelHrRate.Name = "LabelHrRate";
            LabelHrRate.Size = new System.Drawing.Size(87, 17);
            LabelHrRate.TabIndex = 9;
            LabelHrRate.Text = "Hourly Rate:";
            // 
            // TextBoxMI
            // 
            TextBoxMI.Location = new System.Drawing.Point(130, 195);
            TextBoxMI.Name = "TextBoxMI";
            TextBoxMI.Size = new System.Drawing.Size(240, 22);
            TextBoxMI.TabIndex = 4;
            // 
            // NumericUpDownHrRate
            // 
            NumericUpDownHrRate.DecimalPlaces = 2;
            NumericUpDownHrRate.Location = new System.Drawing.Point(130, 223);
            NumericUpDownHrRate.Name = "NumericUpDownHrRate";
            NumericUpDownHrRate.Size = new System.Drawing.Size(240, 22);
            NumericUpDownHrRate.TabIndex = 5;
            // 
            // LabelPosType
            // 
            LabelPosType.AutoSize = true;
            LabelPosType.Location = new System.Drawing.Point(12, 253);
            LabelPosType.Name = "LabelPosType";
            LabelPosType.Size = new System.Drawing.Size(98, 17);
            LabelPosType.TabIndex = 13;
            LabelPosType.Text = "Position Type:";
            // 
            // RadioButtonFWS
            // 
            RadioButtonFWS.AutoSize = true;
            RadioButtonFWS.Location = new System.Drawing.Point(130, 251);
            RadioButtonFWS.Name = "RadioButtonFWS";
            RadioButtonFWS.Size = new System.Drawing.Size(59, 21);
            RadioButtonFWS.TabIndex = 6;
            RadioButtonFWS.TabStop = true;
            RadioButtonFWS.Text = "FWS";
            RadioButtonFWS.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSWS
            // 
            RadioButtonSWS.AutoSize = true;
            RadioButtonSWS.Location = new System.Drawing.Point(195, 251);
            RadioButtonSWS.Name = "RadioButtonSWS";
            RadioButtonSWS.Size = new System.Drawing.Size(60, 21);
            RadioButtonSWS.TabIndex = 7;
            RadioButtonSWS.TabStop = true;
            RadioButtonSWS.Text = "SWS";
            RadioButtonSWS.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMST
            // 
            RadioButtonMST.AutoSize = true;
            RadioButtonMST.Location = new System.Drawing.Point(261, 251);
            RadioButtonMST.Name = "RadioButtonMST";
            RadioButtonMST.Size = new System.Drawing.Size(93, 21);
            RadioButtonMST.TabIndex = 8;
            RadioButtonMST.TabStop = true;
            RadioButtonMST.Text = "SWS MST";
            RadioButtonMST.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHED
            // 
            RadioButtonHED.AutoSize = true;
            RadioButtonHED.Location = new System.Drawing.Point(130, 278);
            RadioButtonHED.Name = "RadioButtonHED";
            RadioButtonHED.Size = new System.Drawing.Size(93, 21);
            RadioButtonHED.TabIndex = 9;
            RadioButtonHED.TabStop = true;
            RadioButtonHED.Text = "SWS HED";
            RadioButtonHED.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHelp
            // 
            RadioButtonHelp.AutoSize = true;
            RadioButtonHelp.Location = new System.Drawing.Point(261, 278);
            RadioButtonHelp.Name = "RadioButtonHelp";
            RadioButtonHelp.Size = new System.Drawing.Size(111, 21);
            RadioButtonHelp.TabIndex = 10;
            RadioButtonHelp.TabStop = true;
            RadioButtonHelp.Text = "Student Help";
            RadioButtonHelp.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTutor1
            // 
            RadioButtonTutor1.AutoSize = true;
            RadioButtonTutor1.Location = new System.Drawing.Point(130, 305);
            RadioButtonTutor1.Name = "RadioButtonTutor1";
            RadioButtonTutor1.Size = new System.Drawing.Size(75, 21);
            RadioButtonTutor1.TabIndex = 11;
            RadioButtonTutor1.TabStop = true;
            RadioButtonTutor1.Text = "Tutor 1";
            RadioButtonTutor1.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTutor2
            // 
            RadioButtonTutor2.AutoSize = true;
            RadioButtonTutor2.Location = new System.Drawing.Point(261, 305);
            RadioButtonTutor2.Name = "RadioButtonTutor2";
            RadioButtonTutor2.Size = new System.Drawing.Size(75, 21);
            RadioButtonTutor2.TabIndex = 12;
            RadioButtonTutor2.TabStop = true;
            RadioButtonTutor2.Text = "Tutor 2";
            RadioButtonTutor2.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTANF
            // 
            RadioButtonTANF.AutoSize = true;
            RadioButtonTANF.Location = new System.Drawing.Point(130, 332);
            RadioButtonTANF.Name = "RadioButtonTANF";
            RadioButtonTANF.Size = new System.Drawing.Size(118, 21);
            RadioButtonTANF.TabIndex = 13;
            RadioButtonTANF.TabStop = true;
            RadioButtonTANF.Text = "TANF Student";
            RadioButtonTANF.UseVisualStyleBackColor = true;
            // 
            // FormAddCard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(382, 387);
            Controls.Add(RadioButtonTANF);
            Controls.Add(RadioButtonTutor2);
            Controls.Add(RadioButtonTutor1);
            Controls.Add(RadioButtonHelp);
            Controls.Add(RadioButtonHED);
            Controls.Add(RadioButtonMST);
            Controls.Add(RadioButtonSWS);
            Controls.Add(RadioButtonFWS);
            Controls.Add(LabelPosType);
            Controls.Add(NumericUpDownHrRate);
            Controls.Add(TextBoxMI);
            Controls.Add(LabelHrRate);
            Controls.Add(LabelMI);
            Controls.Add(LabelSeparator);
            Controls.Add(ButtonAdd);
            Controls.Add(LabelTip);
            Controls.Add(TextBoxCardID);
            Controls.Add(LabelCardID);
            Controls.Add(TextBoxLastName);
            Controls.Add(LabelLastName);
            Controls.Add(LabelFirstName);
            Controls.Add(TextBoxFirstName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(400, 432);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(400, 432);
            Name = "FormAddCard";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Add New Card";
            ((System.ComponentModel.ISupportInitialize)(NumericUpDownHrRate)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label LabelCardID;
        private System.Windows.Forms.TextBox TextBoxCardID;
        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label LabelSeparator;
        private System.Windows.Forms.Label LabelMI;
        private System.Windows.Forms.Label LabelHrRate;
        private System.Windows.Forms.TextBox TextBoxMI;
        private System.Windows.Forms.NumericUpDown NumericUpDownHrRate;
        private System.Windows.Forms.Label LabelPosType;
        private System.Windows.Forms.RadioButton RadioButtonFWS;
        private System.Windows.Forms.RadioButton RadioButtonSWS;
        private System.Windows.Forms.RadioButton RadioButtonMST;
        private System.Windows.Forms.RadioButton RadioButtonHED;
        private System.Windows.Forms.RadioButton RadioButtonHelp;
        private System.Windows.Forms.RadioButton RadioButtonTutor1;
        private System.Windows.Forms.RadioButton RadioButtonTutor2;
        private System.Windows.Forms.RadioButton RadioButtonTANF;
    }
}