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
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void tblPatientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPatientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.tblPatient' table. You can move, or remove it, as needed.
            this.tblPatientTableAdapter.Fill(this.hospitalDataSet.tblPatient);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            tblPatientTableAdapter.Update(hospitalDataSet.tblPatient);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            textBox1.Text = hospitalDataSet.tblPatient[3].Surname;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //tblPatientBindingSource.
        }
    }
}
