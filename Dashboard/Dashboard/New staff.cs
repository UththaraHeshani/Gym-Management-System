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
    public partial class New_staff : Form
    {
        public New_staff()
        {
            InitializeComponent();
        }

        private void New_staff_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNSsave_Click(object sender, EventArgs e)
        {
            String fname = textBoxNSfname.Text;
            String Iname = textBoxNSLname.Text;
            String gender = "";
            bool isChecked = radioButtonNSmale.Checked;
            if (isChecked)
            {
                gender = radioButtonNSmale.Text;
            }
            else
            {
                gender = radioButtonNSfemale.Text;
            }
            String dob = dateTimePickerNSdob.Text;
            int mobile = int.Parse(textBoxNSphone.Text);
            String email = textBoxNSemail.Text;
            String joindate = dateTimePickerNSjoin.Text;
            String address = textBoxNSAdd.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= COLPNLSL309; database=gym; integrated security=true ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Saddress ) values ('" + fname + "','" + Iname + "', '" + gender + "', '" + dob + "', " + mobile + ", '" + email + "', '" + joindate + "', '" + address + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved.");
        }

        private void btnNSreset_Click(object sender, EventArgs e)
        {
            textBoxNSfname.Clear();
            textBoxNSLname.Clear();
            textBoxNSAdd.Clear();
            radioButtonNSmale.Checked = false;
            radioButtonNSfemale.Checked = false;
            textBoxNSphone.Clear();
            textBoxNSemail.Clear();
            dateTimePickerNSdob.Value = DateTime.Now;
            dateTimePickerNSjoin.Value = DateTime.Now;
        }
    }
}
