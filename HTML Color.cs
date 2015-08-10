using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Colors
{
    public partial class Form1 : Form
    {

        private int Red = 0;
        private int Green = 0;
        private int Blue = 0;
        private SortedDictionary<string, string> colors;
        private ScreenColor screenCapture;

        public Form1()
        {
            InitializeComponent();

            this.DefineColors();
            this.colorNames.DataSource = new BindingSource(this.colors, null);
            this.colorNames.DisplayMember = "Key";
            this.colorNames.ValueMember = "Value";
            this.UpdateColor();

        }

        private void trackRed_ValueChanged(object sender, EventArgs e)
        {
            this.numericRed.Value = this.trackRed.Value;
            this.Red = this.trackRed.Value;
            this.UpdateColor();
        }

        private void trackGreen_ValueChanged(object sender, EventArgs e)
        {
            this.numericGreen.Value = this.trackGreen.Value;
            this.Green = this.trackGreen.Value;
            this.UpdateColor();
        }

        private void trackBlue_ValueChanged(object sender, EventArgs e)
        {
            this.numericBlue.Value = this.trackBlue.Value;
            this.Blue = this.trackBlue.Value;
            this.UpdateColor();
        }

        private void numericRed_ValueChanged(object sender, EventArgs e)
        {
            this.trackRed.Value = Decimal.ToInt32(this.numericRed.Value);
            this.Red = Decimal.ToInt32(this.numericRed.Value);
            this.UpdateColor();
        }

        private void numericGreen_ValueChanged(object sender, EventArgs e)
        {
            this.trackGreen.Value = Decimal.ToInt32(this.numericGreen.Value);
            this.Green = Decimal.ToInt32(this.numericGreen.Value);
            this.UpdateColor();
        }

        private void numericBlue_ValueChanged(object sender, EventArgs e)
        {
            this.trackBlue.Value = Decimal.ToInt32(this.numericBlue.Value);
            this.Blue = Decimal.ToInt32(this.numericBlue.Value);
            this.UpdateColor();
        }

        private void UpdateColor()
        {
            string color = "#" + this.GetColorHex();
            this.colorCode.Text = color;
            this.DrawPreviewColor(color);
        }

        private string GetColorHex()
        {
            return this.GetNumberHex(this.Red) + this.GetNumberHex(this.Green) + this.GetNumberHex(this.Blue);
        }

        private string GetNumberHex(int number)
        {
            return number.ToString("X2");
        }

        private void colorNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = ((KeyValuePair<string, string>)this.colorNames.SelectedItem).Value;
            this.colorCode.Text = color;
            this.DrawPreviewColor(color);
        }

        private void DrawPreviewColor(string color_html)
        {
            Color color = ColorTranslator.FromHtml(color_html);
            this.previewColor.BackColor = color;
            this.trackRed.Value = color.R;
            this.trackGreen.Value = color.G;
            this.trackBlue.Value = color.B;
        }

        private void copyColor_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.colorCode.Text);
        }

        private void screenColor_Click(object sender, EventArgs e)
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                               Screen.PrimaryScreen.Bounds.Height,
                               PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);

            if (this.screenCapture == null)
            {
                this.screenCapture = new ScreenColor();
            }
            this.screenCapture.ShowScreen(bmpScreenshot, this);
        }

        public void UpdateColor(Color c)
        {
            string color = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            this.colorCode.Text = color;
            this.DrawPreviewColor(color);
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            if (item.Checked)
            {
                item.Checked = false;
                this.TopMost = false;
            }
            else
            {
                item.Checked = true;
                this.TopMost = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Profesor08, 2015", "About HTML Colors", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void moreColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorPicker.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.UpdateColor(this.colorPicker.Color);
            }
        }

    }
}
