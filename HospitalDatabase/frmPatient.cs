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
        int pos;
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
            pos = this.tblPatientBindingSource.Position;
            txtPosition.Text = Convert.ToString(pos + 1) + " " + "of " + hospitalDataSet.tblPatient.Count;
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
            try
            {
                this.Validate();
                this.tblPatientBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Update(s) successful.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed. /nException: " + ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            int j = this.tblPatientBindingSource.Position;
            try
            {
                tblPatientBindingSource.CancelEdit();
                this.tblPatientTableAdapter.Fill(this.hospitalDataSet.tblPatient);
                this.tblPatientBindingSource.Position = j;
                MessageBox.Show("Update(s) cancelled.");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Cancel failed. /nException: " + ex);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblPatientBindingSource.MoveNext();
            pos = this.tblPatientBindingSource.Position;
            txtPosition.Text = Convert.ToString(pos + 1) + " " + "of " + hospitalDataSet.tblPatient.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblPatientBindingSource.MovePrevious();
            pos = this.tblPatientBindingSource.Position;
            txtPosition.Text = Convert.ToString(pos + 1) + " " + "of " + hospitalDataSet.tblPatient.Count;
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            this.tblPatientBindingSource.MoveLast();
            pos = this.tblPatientBindingSource.Position;
            txtPosition.Text = Convert.ToString(pos + 1) + " " + "of " + hospitalDataSet.tblPatient.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.tblPatientBindingSource.MoveFirst();
            pos = this.tblPatientBindingSource.Position;
            txtPosition.Text = Convert.ToString(pos + 1) + " " + "of " + hospitalDataSet.tblPatient.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.tblPatientBindingSource.RemoveCurrent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblPatientBindingSource.AddNew();
        }
    }
}
