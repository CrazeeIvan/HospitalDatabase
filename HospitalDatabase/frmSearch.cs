using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        private void tblPatientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPatientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.tblPatient' table. You can move, or remove it, as needed.
            this.tblPatientTableAdapter.Fill(this.hospitalDataSet.tblPatient);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           /* SqlConnection conn = new SqlConnection("your connection string");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select col1,col2 FROM TableName where columnId=" + ComboBox1.SelectedValue + "", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textbox1.Text = Convert.ToString(dr["col1"]);
                textbox2.Text = Convert.ToString(dr["col2"]);
            }
            else
            {
                MessageBox.Show("Now Data Found");
            }*/
        }
    }
}
