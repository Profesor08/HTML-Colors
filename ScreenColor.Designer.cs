namespace HTML_Colors
{
    partial class ScreenColor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.curentColor = new System.Windows.Forms.PictureBox();
            this.colorHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curentColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // curentColor
            // 
            this.curentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curentColor.Location = new System.Drawing.Point(255, 199);
            this.curentColor.Margin = new System.Windows.Forms.Padding(0);
            this.curentColor.Name = "curentColor";
            this.curentColor.Size = new System.Drawing.Size(62, 18);
            this.curentColor.TabIndex = 1;
            this.curentColor.TabStop = false;
            // 
            // colorHex
            // 
            this.colorHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorHex.Location = new System.Drawing.Point(255, 182);
            this.colorHex.Margin = new System.Windows.Forms.Padding(0);
            this.colorHex.Name = "colorHex";
            this.colorHex.Size = new System.Drawing.Size(62, 18);
            this.colorHex.TabIndex = 2;
            this.colorHex.Text = "#FFFFFF";
            // 
            // ScreenColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 299);
            this.Controls.Add(this.colorHex);
            this.Controls.Add(this.curentColor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenColor";
            this.Click += new System.EventHandler(this.ScreenColor_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curentColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox curentColor;
        private System.Windows.Forms.Label colorHex;
    }
}