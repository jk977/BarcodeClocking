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
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            LabelStatus = new System.Windows.Forms.Label();
            LabelTip = new System.Windows.Forms.Label();
            LabelInput = new System.Windows.Forms.Label();
            TimerInputTimeout = new System.Windows.Forms.Timer(components);
            MenuStripMain = new System.Windows.Forms.MenuStrip();
            ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemManageCards = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemNewCard = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemRemoveCard = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemManageTime = new System.Windows.Forms.ToolStripMenuItem();
            editAvgHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemEditPast = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemAddTime = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemGenerate = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            Clock = new System.Windows.Forms.Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            dateBox = new System.Windows.Forms.Label();
            MenuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // LabelStatus
            // 
            LabelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelStatus.Location = new System.Drawing.Point(0, 24);
            LabelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new System.Drawing.Size(658, 195);
            LabelStatus.TabIndex = 0;
            LabelStatus.Text = "Waiting for card scan . . .";
            LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTip
            // 
            LabelTip.Dock = System.Windows.Forms.DockStyle.Top;
            LabelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelTip.Location = new System.Drawing.Point(0, 219);
            LabelTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelTip.Name = "LabelTip";
            LabelTip.Size = new System.Drawing.Size(658, 144);
            LabelTip.TabIndex = 1;
            LabelTip.Text = "Scan a card or type in your Student ID to clock in or clock out.";
            LabelTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelInput
            // 
            LabelInput.AutoSize = true;
            LabelInput.Location = new System.Drawing.Point(9, 23);
            LabelInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelInput.Name = "LabelInput";
            LabelInput.Size = new System.Drawing.Size(36, 13);
            LabelInput.TabIndex = 2;
            LabelInput.Text = "input: ";
            // 
            // TimerInputTimeout
            // 
            TimerInputTimeout.Interval = 15000;
            TimerInputTimeout.Tick += new System.EventHandler(TimerInputTimeout_Tick);
            // 
            // MenuStripMain
            // 
            MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItemFile,
            ToolStripMenuItemManageCards,
            ToolStripMenuItemManageTime,
            ToolStripMenuItemReports,
            ToolStripMenuItemSettings,
            ToolStripMenuItemHelp});
            MenuStripMain.Location = new System.Drawing.Point(0, 0);
            MenuStripMain.Name = "MenuStripMain";
            MenuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            MenuStripMain.Size = new System.Drawing.Size(658, 24);
            MenuStripMain.TabIndex = 3;
            MenuStripMain.Text = "Menu Strip";
            // 
            // ToolStripMenuItemFile
            // 
            ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItemExit});
            ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            ToolStripMenuItemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            ToolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            ToolStripMenuItemFile.Text = "&File";
            // 
            // ToolStripMenuItemExit
            // 
            ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            ToolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            ToolStripMenuItemExit.Size = new System.Drawing.Size(129, 22);
            ToolStripMenuItemExit.Text = "E&xit";
            ToolStripMenuItemExit.Click += new System.EventHandler(ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemManageCards
            // 
            ToolStripMenuItemManageCards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItemNewCard,
            ToolStripMenuItemEdit,
            ToolStripMenuItemRemoveCard});
            ToolStripMenuItemManageCards.Name = "ToolStripMenuItemManageCards";
            ToolStripMenuItemManageCards.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            ToolStripMenuItemManageCards.Size = new System.Drawing.Size(95, 20);
            ToolStripMenuItemManageCards.Text = "Manage &Cards";
            // 
            // ToolStripMenuItemNewCard
            // 
            ToolStripMenuItemNewCard.Name = "ToolStripMenuItemNewCard";
            ToolStripMenuItemNewCard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            ToolStripMenuItemNewCard.Size = new System.Drawing.Size(186, 22);
            ToolStripMenuItemNewCard.Text = "Add &new card";
            ToolStripMenuItemNewCard.Click += new System.EventHandler(ToolStripMenuItemNewCard_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            ToolStripMenuItemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            ToolStripMenuItemEdit.Size = new System.Drawing.Size(186, 22);
            ToolStripMenuItemEdit.Text = "&Edit card";
            ToolStripMenuItemEdit.Click += new System.EventHandler(ToolStripMenuItemEdit_Click);
            // 
            // ToolStripMenuItemRemoveCard
            // 
            ToolStripMenuItemRemoveCard.Name = "ToolStripMenuItemRemoveCard";
            ToolStripMenuItemRemoveCard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            ToolStripMenuItemRemoveCard.Size = new System.Drawing.Size(186, 22);
            ToolStripMenuItemRemoveCard.Text = "Re&move card";
            ToolStripMenuItemRemoveCard.Click += new System.EventHandler(ToolStripMenuItemRemoveCard_Click);
            // 
            // ToolStripMenuItemManageTime
            // 
            ToolStripMenuItemManageTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            editAvgHoursToolStripMenuItem,
            ToolStripMenuItemEditPast,
            ToolStripMenuItemAddTime});
            ToolStripMenuItemManageTime.Name = "ToolStripMenuItemManageTime";
            ToolStripMenuItemManageTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            ToolStripMenuItemManageTime.Size = new System.Drawing.Size(92, 20);
            ToolStripMenuItemManageTime.Text = "Manage &Time";
            // 
            // editAvgHoursToolStripMenuItem
            // 
            editAvgHoursToolStripMenuItem.Name = "editAvgHoursToolStripMenuItem";
            editAvgHoursToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            editAvgHoursToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            editAvgHoursToolStripMenuItem.Text = "Edit avg. Hours";
            editAvgHoursToolStripMenuItem.Click += new System.EventHandler(editAvgHoursToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemEditPast
            // 
            ToolStripMenuItemEditPast.Name = "ToolStripMenuItemEditPast";
            ToolStripMenuItemEditPast.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            ToolStripMenuItemEditPast.Size = new System.Drawing.Size(211, 22);
            ToolStripMenuItemEditPast.Text = "Edit &past time";
            ToolStripMenuItemEditPast.Click += new System.EventHandler(ToolStripMenuItemEditPast_Click);
            // 
            // ToolStripMenuItemAddTime
            // 
            ToolStripMenuItemAddTime.Name = "ToolStripMenuItemAddTime";
            ToolStripMenuItemAddTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            ToolStripMenuItemAddTime.Size = new System.Drawing.Size(211, 22);
            ToolStripMenuItemAddTime.Text = "Manually a&dd time";
            ToolStripMenuItemAddTime.Click += new System.EventHandler(ToolStripMenuItemAddTime_Click);
            // 
            // ToolStripMenuItemReports
            // 
            ToolStripMenuItemReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItemGenerate});
            ToolStripMenuItemReports.Name = "ToolStripMenuItemReports";
            ToolStripMenuItemReports.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            ToolStripMenuItemReports.Size = new System.Drawing.Size(59, 20);
            ToolStripMenuItemReports.Text = "&Reports";
            // 
            // ToolStripMenuItemGenerate
            // 
            ToolStripMenuItemGenerate.Name = "ToolStripMenuItemGenerate";
            ToolStripMenuItemGenerate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            ToolStripMenuItemGenerate.Size = new System.Drawing.Size(217, 22);
            ToolStripMenuItemGenerate.Text = "&Generate time sheet";
            ToolStripMenuItemGenerate.Click += new System.EventHandler(TimeSheetToolStripMenuItemGenerate_Click);
            // 
            // ToolStripMenuItemSettings
            // 
            ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            ToolStripMenuItemSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            ToolStripMenuItemSettings.Size = new System.Drawing.Size(61, 20);
            ToolStripMenuItemSettings.Text = "&Settings";
            ToolStripMenuItemSettings.Visible = false;
            // 
            // ToolStripMenuItemHelp
            // 
            ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItemAbout});
            ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            ToolStripMenuItemHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            ToolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            ToolStripMenuItemHelp.Text = "&Help";
            // 
            // ToolStripMenuItemAbout
            // 
            ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            ToolStripMenuItemAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            ToolStripMenuItemAbout.Size = new System.Drawing.Size(145, 22);
            ToolStripMenuItemAbout.Text = "&About";
            ToolStripMenuItemAbout.Click += new System.EventHandler(ToolStripMenuItemAbout_Click);
            // 
            // Clock
            // 
            Clock.Dock = System.Windows.Forms.DockStyle.Top;
            Clock.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Clock.Location = new System.Drawing.Point(0, 363);
            Clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Clock.Name = "Clock";
            Clock.Size = new System.Drawing.Size(658, 108);
            Clock.TabIndex = 2;
            Clock.Text = "Clock";
            Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += new System.EventHandler(clockTimer_Tick);
            // 
            // dateBox
            // 
            dateBox.Dock = System.Windows.Forms.DockStyle.Top;
            dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateBox.Location = new System.Drawing.Point(0, 471);
            dateBox.Name = "dateBox";
            dateBox.Size = new System.Drawing.Size(658, 42);
            dateBox.TabIndex = 4;
            dateBox.Text = "Date";
            dateBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(658, 581);
            Controls.Add(dateBox);
            Controls.Add(Clock);
            Controls.Add(LabelInput);
            Controls.Add(LabelTip);
            Controls.Add(LabelStatus);
            Controls.Add(MenuStripMain);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MainMenuStrip = MenuStripMain;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FormMain";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Barcode Clocking";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Deactivate += new System.EventHandler(FormMain_Deactivate);
            KeyPress += new System.Windows.Forms.KeyPressEventHandler(FormMain_KeyPress);
            MenuStripMain.ResumeLayout(false);
            MenuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Timer TimerInputTimeout;
        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemManageCards;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewCard;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRemoveCard;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReports;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGenerate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemManageTime;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditPast;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddTime;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label dateBox;
        private System.Windows.Forms.ToolStripMenuItem editAvgHoursToolStripMenuItem;
    }
}