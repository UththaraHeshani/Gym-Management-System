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
    public partial class Delete_Member : Form
    {
        public Delete_Member()
        {
            InitializeComponent();
        }

        private void btnDMsearch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data. Confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= COLPNLSL309; database=gym; integrated security=true ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "delete  from NewMember where MID = " + textBoxDMDelete.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= COLPNLSL309; database=gym; integrated security=true ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "select * from NewMember ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewDM.DataSource = DS.Tables[0];
            }
        }

        private void Delete_Member_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= COLPNLSL309; database=gym; integrated security=true ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from NewMember ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridViewDM.DataSource = DS.Tables[0];
        }
    }
    }

