namespace HTML_Colors
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.numericBlue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericGreen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericRed = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.screenColor = new System.Windows.Forms.Button();
            this.copyColor = new System.Windows.Forms.Button();
            this.previewColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorNames = new System.Windows.Forms.ComboBox();
            this.colorCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHTMLCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.buttonCopyRGBA = new System.Windows.Forms.Button();
            this.buttonCopyHSL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewColor)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBlue);
            this.groupBox1.Controls.Add(this.trackGreen);
            this.groupBox1.Controls.Add(this.trackRed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericBlue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericGreen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericRed);
            this.groupBox1.Location = new System.Drawing.Point(-1, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // trackBlue
            // 
            this.trackBlue.AutoSize = false;
            this.trackBlue.Location = new System.Drawing.Point(94, 51);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBlue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBlue.Size = new System.Drawing.Size(35, 211);
            this.trackBlue.TabIndex = 10;
            this.trackBlue.TickFrequency = 10;
            this.trackBlue.ValueChanged += new System.EventHandler(this.trackBlue_ValueChanged);
            // 
            // trackGreen
            // 
            this.trackGreen.AutoSize = false;
            this.trackGreen.Location = new System.Drawing.Point(50, 51);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackGreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackGreen.Size = new System.Drawing.Size(35, 211);
            this.trackGreen.TabIndex = 9;
            this.trackGreen.TickFrequency = 10;
            this.trackGreen.ValueChanged += new System.EventHandler(this.trackGreen_ValueChanged);
            // 
            // trackRed
            // 
            this.trackRed.AutoSize = false;
            this.trackRed.Location = new System.Drawing.Point(6, 51);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackRed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackRed.Size = new System.Drawing.Size(35, 211);
            this.trackRed.TabIndex = 8;
            this.trackRed.TickFrequency = 10;
            this.trackRed.ValueChanged += new System.EventHandler(this.trackRed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(91, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // numericBlue
            // 
            this.numericBlue.Location = new System.Drawing.Point(94, 25);
            this.numericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue.Name = "numericBlue";
            this.numericBlue.Size = new System.Drawing.Size(38, 20);
            this.numericBlue.TabIndex = 4;
            this.numericBlue.ValueChanged += new System.EventHandler(this.numericBlue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "G";
            // 
            // numericGreen
            // 
            this.numericGreen.Location = new System.Drawing.Point(50, 25);
            this.numericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen.Name = "numericGreen";
            this.numericGreen.Size = new System.Drawing.Size(38, 20);
            this.numericGreen.TabIndex = 2;
            this.numericGreen.ValueChanged += new System.EventHandler(this.numericGreen_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // numericRed
            // 
            this.numericRed.Location = new System.Drawing.Point(6, 25);
            this.numericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed.Name = "numericRed";
            this.numericRed.Size = new System.Drawing.Size(38, 20);
            this.numericRed.TabIndex = 0;
            this.numericRed.ValueChanged += new System.EventHandler(this.numericRed_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCopyHSL);
            this.groupBox2.Controls.Add(this.buttonCopyRGBA);
            this.groupBox2.Controls.Add(this.screenColor);
            this.groupBox2.Controls.Add(this.copyColor);
            this.groupBox2.Controls.Add(this.previewColor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.colorNames);
            this.groupBox2.Controls.Add(this.colorCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(136, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 264);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // screenColor
            // 
            this.screenColor.Location = new System.Drawing.Point(57, 234);
            this.screenColor.Name = "screenColor";
            this.screenColor.Size = new System.Drawing.Size(49, 23);
            this.screenColor.TabIndex = 6;
            this.screenColor.Text = "Screen";
            this.screenColor.UseVisualStyleBackColor = true;
            this.screenColor.Click += new System.EventHandler(this.screenColor_Click);
            // 
            // copyColor
            // 
            this.copyColor.Location = new System.Drawing.Point(6, 234);
            this.copyColor.Name = "copyColor";
            this.copyColor.Size = new System.Drawing.Size(45, 23);
            this.copyColor.TabIndex = 5;
            this.copyColor.Text = "Copy 📋";
            this.copyColor.UseVisualStyleBackColor = true;
            this.copyColor.Click += new System.EventHandler(this.copyColor_Click);
            // 
            // previewColor
            // 
            this.previewColor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.previewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewColor.Location = new System.Drawing.Point(6, 99);
            this.previewColor.Name = "previewColor";
            this.previewColor.Size = new System.Drawing.Size(100, 100);
            this.previewColor.TabIndex = 4;
            this.previewColor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Color Name:";
            // 
            // colorNames
            // 
            this.colorNames.FormattingEnabled = true;
            this.colorNames.Location = new System.Drawing.Point(6, 72);
            this.colorNames.Name = "colorNames";
            this.colorNames.Size = new System.Drawing.Size(100, 21);
            this.colorNames.TabIndex = 2;
            this.colorNames.SelectedIndexChanged += new System.EventHandler(this.colorNames_SelectedIndexChanged);
            // 
            // colorCode
            // 
            this.colorCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorCode.Location = new System.Drawing.Point(6, 24);
            this.colorCode.Name = "colorCode";
            this.colorCode.Size = new System.Drawing.Size(100, 30);
            this.colorCode.TabIndex = 1;
            this.colorCode.Text = "#000000";
            this.colorCode.TextChanged += new System.EventHandler(this.colorCode_TextChanged);
            this.colorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colorCode_KeyPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "HTML Code:";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.moreColorsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(248, 24);
            this.mainMenu.TabIndex = 12;
            this.mainMenu.Text = "mainMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyHTMLCodeToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // copyHTMLCodeToolStripMenuItem
            // 
            this.copyHTMLCodeToolStripMenuItem.Name = "copyHTMLCodeToolStripMenuItem";
            this.copyHTMLCodeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyHTMLCodeToolStripMenuItem.Text = "Copy HTML Code";
            this.copyHTMLCodeToolStripMenuItem.Click += new System.EventHandler(this.copyColor_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // moreColorsToolStripMenuItem
            // 
            this.moreColorsToolStripMenuItem.Name = "moreColorsToolStripMenuItem";
            this.moreColorsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.moreColorsToolStripMenuItem.Text = "More Colors";
            this.moreColorsToolStripMenuItem.Click += new System.EventHandler(this.moreColorsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonCopyRGBA
            // 
            this.buttonCopyRGBA.Location = new System.Drawing.Point(6, 205);
            this.buttonCopyRGBA.Name = "buttonCopyRGBA";
            this.buttonCopyRGBA.Size = new System.Drawing.Size(45, 23);
            this.buttonCopyRGBA.TabIndex = 7;
            this.buttonCopyRGBA.Text = "RGB";
            this.buttonCopyRGBA.UseVisualStyleBackColor = true;
            this.buttonCopyRGBA.Click += new System.EventHandler(this.buttonCopyRGBA_Click);
            // 
            // buttonCopyHSL
            // 
            this.buttonCopyHSL.Location = new System.Drawing.Point(58, 205);
            this.buttonCopyHSL.Name = "buttonCopyHSL";
            this.buttonCopyHSL.Size = new System.Drawing.Size(48, 23);
            this.buttonCopyHSL.TabIndex = 8;
            this.buttonCopyHSL.Text = "HSL";
            this.buttonCopyHSL.UseVisualStyleBackColor = true;
            this.buttonCopyHSL.Click += new System.EventHandler(this.buttonCopyHSL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML Colors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewColor)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericRed;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colorCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox colorNames;
        private System.Windows.Forms.PictureBox previewColor;
        private System.Windows.Forms.Button screenColor;
        private System.Windows.Forms.Button copyColor;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyHTMLCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreColorsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button buttonCopyHSL;
        private System.Windows.Forms.Button buttonCopyRGBA;
    }
}

