using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Colors
{
    public partial class ScreenColor : Form
    {

        Form1 parent;

        public ScreenColor()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void ScreenColor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                this.parent.UpdateColor(GetClickedPixel(mouse.Location));
            }
            this.Close();
        }

        private Color GetClickedPixel(Point point)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            return bitmap.GetPixel(point.X, point.Y);
        }

        public void ShowScreen(Bitmap picture, Form1 parent)
        {
            this.pictureBox1.Image = picture;
            this.parent = parent;
            this.ShowDialog();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = GetClickedPixel(e.Location);
            this.curentColor.BackColor = color;
            this.colorHex.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");

            int X = e.Location.X;
            int Y = e.Location.Y;

            if (Y > this.Height - 32)
            {
                Y -= 60;
            }

            if (X > this.Width - 70)
            {
                X -= 70;
            }

            this.colorHex.Location = new Point(X, Y + 18);
            this.curentColor.Location = new Point(X, Y + 32);
        }

    }
}
