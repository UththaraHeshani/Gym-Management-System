using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Boolean b = true;
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C: \Users\Uththara Heshani\OneDrive\Desktop\Github\Gym - Management - System\Images\Up Down Arrow Vector Art PNG, Vector Down Arrow Icon, Arrow Icons, Down Icons, Arrow PNG Image For Free Download.jpeg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C: \Users\Uththara Heshani\OneDrive\Desktop\Github\Gym - Management - System\Images\Free right arrow icon png vector - Pixsector_ Free vector images, mockups, PSDs and photos.jpeg");
            }
        }
        
        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member nm = new New_Member();
            nm.Show();


        }
    }
}
