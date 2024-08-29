using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiToolbarWindowsFormApp
{
    public partial class EmojiToolbar : Form
    {
        // class variables
        private bool _panning = false;
        private Point _panCursorPoint;
        private Point _panFormPoint;

        public EmojiToolbar()
        {
            InitializeComponent();
        }

        private void pictureBoxPan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // start toolbar panning
                _panning = true;
                _panCursorPoint = Cursor.Position;
                _panFormPoint = this.Location;
                pictureBoxPan.BackgroundImage = Properties.Resources.MoveIcon;
                pictureBoxPan.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void pictureBoxPan_MouseMove(object sender, MouseEventArgs e)
        {
            // pan the toolbar
            if (_panning)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_panCursorPoint));
                this.Location = Point.Add(_panFormPoint, new Size(dif));
            }
        }

        private void pictureBoxPan_MouseUp(object sender, MouseEventArgs e)
        {
            // end toolbar panning
            _panning = false;
            pictureBoxPan.BackgroundImage = null;
        }

        // closes the form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("😩");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("👌");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("🦵");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("👃");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("🗿");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("🤔");
        }
    }
}
