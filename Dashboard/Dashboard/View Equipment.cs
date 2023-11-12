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
    public partial class View_Equipment : Form
    {
        public View_Equipment()
        {
            InitializeComponent();
        }

        private void View_Equipment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= COLPNLSL309; database=gym; integrated security=true ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText= "select * from Equipment";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS =new DataSet();
            DA.Fill(DS);
            dataGridViewEq.DataSource = DS.Tables[0];
        }
    }
}
