using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            this.LoadSave();

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\HTML-Colors", true);

            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey("Software\\HTML-Colors");
            }

            key.SetValue("Red", this.Red);
            key.SetValue("Green", this.Green);
            key.SetValue("Blue", this.Blue);
        }

        private void LoadSave()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\HTML-Colors", true))
            {
                if (key == null)
                {
                    return;
                }

                this.Red = (int)key.GetValue("Red", 0, RegistryValueOptions.None);
                this.Green = (int)key.GetValue("Green", 0, RegistryValueOptions.None);
                this.Blue = (int)key.GetValue("Blue", 0, RegistryValueOptions.None);

                this.UpdateColor();
            }
        }

        string oldColor = "#000000";

        private void colorCode_TextChanged(object sender, EventArgs e)
        {
            TextBox code = (TextBox)sender;

            //MessageBox.Show(this.inputMatchColorHex(code.Text).ToString());

            if (code.Text.Length == 0)
            {
                code.Text = "#";
            }

            if (!this.inputMatchColorHex(code.Text))
            {
                code.Text = oldColor;
            }
        }

        private bool inputMatchColorHex(string color)
        {
            return Regex.IsMatch(color, @"^[#]?([0-9a-fA-F]{3,3}|[0-9a-fA-F]{6,6})$");
        }

        private void colorCode_KeyPressed(object sender, KeyPressEventArgs e)
        {
            /*TextBox code = (TextBox)sender;

            if (code.Text.Length == 7)
            {
                e.Handled = true;
            }

            if (code.Text.Length == 0 && e.KeyChar.ToString() != "#")
            {
                code.Text = "#";
                e.Handled = true;
            }

            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[0-9a-fA-F]"))
            {
                e.Handled = true;
            }*/
        }

        private string getHSLColor()
        {
            float _R = (this.Red / 255f);
            float _G = (this.Green / 255f);
            float _B = (this.Blue / 255f);

            float _Min = Math.Min(Math.Min(_R, _G), _B);
            float _Max = Math.Max(Math.Max(_R, _G), _B);
            float _Delta = _Max - _Min;

            float H = 0;
            float S = 0;
            float L = (float)((_Max + _Min) / 2.0f);

            if (_Delta != 0)
            {
                if (L < 0.5f)
                {
                    S = (float)(_Delta / (_Max + _Min));
                }
                else
                {
                    S = (float)(_Delta / (2.0f - _Max - _Min));
                }


                if (_R == _Max)
                {
                    H = (_G - _B) / _Delta;
                }
                else if (_G == _Max)
                {
                    H = 2f + (_B - _R) / _Delta;
                }
                else if (_B == _Max)
                {
                    H = 4f + (_R - _G) / _Delta;
                }
            }

            return "hsl(" + H.ToString(CultureInfo.InvariantCulture) + ", " + S.ToString(CultureInfo.InvariantCulture) + ", " + L.ToString(CultureInfo.InvariantCulture) + ")";
        }

        private string getRGBAColor()
        {
            return "rgba(" + this.Red + ", " + this.Blue + ", " + this.Green + ", 1)";
        }

        private void buttonCopyRGBA_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(getRGBAColor());
        }

        private void buttonCopyHSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(getHSLColor());
        }
    }
}
