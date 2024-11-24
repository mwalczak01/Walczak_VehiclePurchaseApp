namespace Walczak_VehiclePurchaseApp
{
    partial class Form1
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
            this.baseBox = new System.Windows.Forms.TextBox();
            this.tradeBox = new System.Windows.Forms.TextBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.tradeLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createdByMatthewWalczakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stereoBox = new System.Windows.Forms.CheckBox();
            this.leatherIntBox = new System.Windows.Forms.CheckBox();
            this.compNavBox = new System.Windows.Forms.CheckBox();
            this.standardBox = new System.Windows.Forms.CheckBox();
            this.pearlizeBox = new System.Windows.Forms.CheckBox();
            this.customBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseBox
            // 
            this.baseBox.Location = new System.Drawing.Point(227, 39);
            this.baseBox.Name = "baseBox";
            this.baseBox.Size = new System.Drawing.Size(100, 22);
            this.baseBox.TabIndex = 1;
            // 
            // tradeBox
            // 
            this.tradeBox.Location = new System.Drawing.Point(227, 67);
            this.tradeBox.Name = "tradeBox";
            this.tradeBox.Size = new System.Drawing.Size(100, 22);
            this.tradeBox.TabIndex = 3;
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(48, 45);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(76, 16);
            this.baseLabel.TabIndex = 0;
            this.baseLabel.Text = "Base Price:";
            // 
            // tradeLabel
            // 
            this.tradeLabel.AutoSize = true;
            this.tradeLabel.Location = new System.Drawing.Point(48, 76);
            this.tradeLabel.Name = "tradeLabel";
            this.tradeLabel.Size = new System.Drawing.Size(126, 16);
            this.tradeLabel.TabIndex = 2;
            this.tradeLabel.Text = "Trade-In Allowance:";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(48, 336);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(68, 16);
            this.subLabel.TabIndex = 11;
            this.subLabel.Text = "Sub Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(76, 351);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 16);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTab,
            this.calculateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTab
            // 
            this.fileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileTab.Name = "fileTab";
            this.fileTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileTab.Size = new System.Drawing.Size(46, 24);
            this.fileTab.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.aboutToolStripMenuItem.Text = "Exit";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem1,
            this.clearToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.calculateToolStripMenuItem.Text = "Edit";
            // 
            // calculateToolStripMenuItem1
            // 
            this.calculateToolStripMenuItem1.Name = "calculateToolStripMenuItem1";
            this.calculateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.calculateToolStripMenuItem1.Text = "Calculate";
            this.calculateToolStripMenuItem1.Click += new System.EventHandler(this.calculateToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createdByMatthewWalczakToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // createdByMatthewWalczakToolStripMenuItem
            // 
            this.createdByMatthewWalczakToolStripMenuItem.Name = "createdByMatthewWalczakToolStripMenuItem";
            this.createdByMatthewWalczakToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.createdByMatthewWalczakToolStripMenuItem.Text = "Created by Matthew Walczak";
            // 
            // stereoBox
            // 
            this.stereoBox.AutoSize = true;
            this.stereoBox.Location = new System.Drawing.Point(51, 116);
            this.stereoBox.Name = "stereoBox";
            this.stereoBox.Size = new System.Drawing.Size(209, 20);
            this.stereoBox.TabIndex = 4;
            this.stereoBox.Text = "Stereo System..................425.76";
            this.stereoBox.UseVisualStyleBackColor = true;
            // 
            // leatherIntBox
            // 
            this.leatherIntBox.AutoSize = true;
            this.leatherIntBox.Location = new System.Drawing.Point(51, 142);
            this.leatherIntBox.Name = "leatherIntBox";
            this.leatherIntBox.Size = new System.Drawing.Size(206, 20);
            this.leatherIntBox.TabIndex = 5;
            this.leatherIntBox.Text = "Leather Interior.................987.41";
            this.leatherIntBox.UseVisualStyleBackColor = true;
            // 
            // compNavBox
            // 
            this.compNavBox.AutoSize = true;
            this.compNavBox.Location = new System.Drawing.Point(51, 168);
            this.compNavBox.Name = "compNavBox";
            this.compNavBox.Size = new System.Drawing.Size(227, 20);
            this.compNavBox.TabIndex = 6;
            this.compNavBox.Text = "Computer Navigation........1,741.23";
            this.compNavBox.UseVisualStyleBackColor = true;
            // 
            // standardBox
            // 
            this.standardBox.AutoSize = true;
            this.standardBox.Location = new System.Drawing.Point(51, 194);
            this.standardBox.Name = "standardBox";
            this.standardBox.Size = new System.Drawing.Size(290, 20);
            this.standardBox.TabIndex = 7;
            this.standardBox.Text = "Standard...........................No additional charge";
            this.standardBox.UseVisualStyleBackColor = true;
            // 
            // pearlizeBox
            // 
            this.pearlizeBox.AutoSize = true;
            this.pearlizeBox.Location = new System.Drawing.Point(51, 220);
            this.pearlizeBox.Name = "pearlizeBox";
            this.pearlizeBox.Size = new System.Drawing.Size(203, 20);
            this.pearlizeBox.TabIndex = 8;
            this.pearlizeBox.Text = "Pearlize.............................345.72";
            this.pearlizeBox.UseVisualStyleBackColor = true;
            // 
            // customBox
            // 
            this.customBox.AutoSize = true;
            this.customBox.Location = new System.Drawing.Point(51, 245);
            this.customBox.Name = "customBox";
            this.customBox.Size = new System.Drawing.Size(217, 20);
            this.customBox.TabIndex = 9;
            this.customBox.Text = "Customized Detailing........599.99";
            this.customBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "*Sales Tax: 8%";
            // 
            // subOutput
            // 
            this.subOutput.AutoSize = true;
            this.subOutput.Location = new System.Drawing.Point(123, 335);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(24, 16);
            this.subOutput.TabIndex = 12;
            this.subOutput.Text = "$ 0";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(123, 351);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(24, 16);
            this.totalOutput.TabIndex = 14;
            this.totalOutput.Text = "$ 0";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(33, 367);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(83, 16);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Amount Due:";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // amountOutput
            // 
            this.amountOutput.AutoSize = true;
            this.amountOutput.Location = new System.Drawing.Point(122, 367);
            this.amountOutput.Name = "amountOutput";
            this.amountOutput.Size = new System.Drawing.Size(24, 16);
            this.amountOutput.TabIndex = 17;
            this.amountOutput.Text = "$ 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountOutput);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customBox);
            this.Controls.Add(this.pearlizeBox);
            this.Controls.Add(this.standardBox);
            this.Controls.Add(this.compNavBox);
            this.Controls.Add(this.leatherIntBox);
            this.Controls.Add(this.stereoBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.tradeLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.tradeBox);
            this.Controls.Add(this.baseBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vehicle Purchase App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseBox;
        private System.Windows.Forms.TextBox tradeBox;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label tradeLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTab;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createdByMatthewWalczakToolStripMenuItem;
        private System.Windows.Forms.CheckBox stereoBox;
        private System.Windows.Forms.CheckBox leatherIntBox;
        private System.Windows.Forms.CheckBox compNavBox;
        private System.Windows.Forms.CheckBox standardBox;
        private System.Windows.Forms.CheckBox pearlizeBox;
        private System.Windows.Forms.CheckBox customBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label amountOutput;
    }
}

