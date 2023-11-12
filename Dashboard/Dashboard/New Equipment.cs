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
    public partial class New_Equipment : Form
    {
        public New_Equipment()
        {
            InitializeComponent();
        }

        private void btnEqsave_Click(object sender, EventArgs e)
        {
            String EquipName = textBoxEname.Text;
            String Description = textBoxEdes.Text;
            String MUsed = textBoxEmus.Text;
            String DDate = dateTimePickerEq.Text;
            Int64 cost = Int64.Parse(textBoxEqcost.Text);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= COLPNLSL309; database=gym; integrated security=true ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Equipment (EquipName, EDescription, MUsed, DDate, Cost ) values ('" + EquipName + "','" + Description + "', '" + MUsed + "', '" + DDate + "', '" + cost + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved." ,"Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEqRest_Click(object sender, EventArgs e)
        {
            textBoxEname.Clear();
            textBoxEdes.Clear();
            textBoxEmus.Clear();
           textBoxEqcost.Clear();
            dateTimePickerEq.Value = DateTime.Now;
        }

        private void btnEqView_Click(object sender, EventArgs e)
        {
            View_Equipment ve = new View_Equipment();
            ve.Show();
        }
    }
}
