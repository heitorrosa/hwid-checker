using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWIDCheckerForms
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;

        public Form1()
        {
            InitializeComponent();

            string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            label1.Text = HWID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void copy_Click(object sender, EventArgs e)
        {
            string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            Clipboard.SetText(HWID);
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }

        }

        private void mouse_Up(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
