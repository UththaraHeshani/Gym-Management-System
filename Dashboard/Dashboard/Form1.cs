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
            Delete_Member Dm=new Delete_Member();
            Dm.Show();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member nm = new New_Member();
            nm.Show();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*menuStrip1.AutoSize = false;
            menuStrip1.Size = new Size(1100, 50);*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newStafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_staff ns = new New_staff();
            ns.Show();
        }

        private void equToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Equipment ne= new New_Equipment();
            ne. Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close Your application.Confirm?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log OUT !! Confirm?", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login lg=new Login();
                lg.Show();
            }
            

        }
    }
}
