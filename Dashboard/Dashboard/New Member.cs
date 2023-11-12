using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class New_Member : Form
    {
        public New_Member()
        {
            InitializeComponent();
        }

        private void New_Member_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNMsave_Click(object sender, EventArgs e)
        {
            string fname=textBox1NMname.Text;
            string lname=textBoxNMLname.Text;
            string gender = "";
            bool isChacked=radioButtonNMmale.Checked;
            if (isChacked)
            {
                gender=radioButtonNMmale.Text;
            }
            else
            {
                gender = radioButtonNMfemale.Text;
            }
            string dob=dateTimePickerNMdob.Text;
            int mobile = int.Parse(textBoxNMphone.Text);
            string email=textBoxNMemail.Text;
            string joindate = dateTimePickerNMjoin.Text;
            string gymtime=comboBoxNMgym.Text;
            string address = textBoxNMadd.Text;
            string membersiptime=comboBoxNMmem.Text;



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= COLPNLSL309; database=gym; integrated security=true ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText= "insert into NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime) values ('" + fname + "','" + lname + "', '" + gender + "', '" + dob + "', " + mobile + ", '" + email + "', '" +joindate + "', '" + gymtime + "', '"+ address +"', '"+ membersiptime + "')";
            SqlDataAdapter DA=new SqlDataAdapter(cmd);
            DataSet DS=new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved.");

        }

        private void btnNMRest_Click(object sender, EventArgs e)
        {
            textBox1NMname.Clear();
          textBoxNMLname.Clear();
            textBoxNMadd.Clear();
            radioButtonNMmale.Checked = false;
            radioButtonNMfemale.Checked = false;
            textBoxNMphone.Clear();
            textBoxNMemail.Clear();
            comboBoxNMgym.ResetText();
            comboBoxNMmem.ResetText();
            dateTimePickerNMdob.Value= DateTime.Now;
            dateTimePickerNMjoin.Value= DateTime.Now;
        }
    }
}
