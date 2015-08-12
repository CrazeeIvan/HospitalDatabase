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
        string newline = Environment.NewLine;
        public frmSearch()
        {
            InitializeComponent();
        }
        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.tblPatient' table. You can move, or remove it, as needed.
            cboField.SelectedIndex = 0;
            cboOperator.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            switch (cboField.SelectedItem.ToString())
            {
                case "PatientID":
                    switch (cboOperator.SelectedItem.ToString())
                    {
                        case "Equals =":
                            try
                            {
                                tblPatientTableAdapter.FillByPatientEquals(hospitalDataSet.tblPatient, Convert.ToInt32(txtSearch.Text));
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Less than <":
                            try
                            {
                                tblPatientTableAdapter.FillByPatientLess(hospitalDataSet.tblPatient, Convert.ToInt32(txtSearch.Text));
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Greater than >":
                            try
                            {
                                tblPatientTableAdapter.FillByPatientGreater(hospitalDataSet.tblPatient, Convert.ToInt32(txtSearch.Text));
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                    }
                    break;
                case "Surname":
                    switch (cboOperator.SelectedItem.ToString())
                    {
                        case "Equals =":
                            try
                            {
                                tblPatientTableAdapter.FillBySurnameEquals(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Less than <":
                            try
                            {
                                tblPatientTableAdapter.FillBySurnameLess(hospitalDataSet.tblPatient,txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Greater than >":
                            try
                            {
                                tblPatientTableAdapter.FillBySurnameGreater(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                    }
                    break;
                case "FirstName":
                    switch (cboOperator.SelectedItem.ToString())
                    {
                        case "Equals =":
                            try
                            {
                                tblPatientTableAdapter.FillByFirstNameEquals(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Less than <":
                            try
                            {
                                tblPatientTableAdapter.FillByFirstNameLess(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Greater than >":
                            try
                            {
                                tblPatientTableAdapter.FillByFirstNameGreater(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                    }
                    break;
                case "Gender":
                    switch (cboOperator.SelectedItem.ToString())
                    {
                        case "Equals =":
                            try
                            {
                                tblPatientTableAdapter.FillByGenderEquals(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Less than <":
                            try
                            {
                                tblPatientTableAdapter.FillByGenderLess(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Greater than >":
                            try
                            {
                                tblPatientTableAdapter.FillByGenderGreater(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                    }
                    break;
                case "WardName":
                    switch (cboOperator.SelectedItem.ToString())
                    {
                        case "Equals =":
                            try
                            {
                                tblPatientTableAdapter.FillByWardNameEquals(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Less than <":
                            try
                            {
                                tblPatientTableAdapter.FillByWardNameLess(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Greater than >":
                            try
                            {
                                tblPatientTableAdapter.FillByWardNameGreater(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                    }
                    break;
                case "DateOfBirth":
                    switch (cboOperator.SelectedItem.ToString())
                    {
                        case "Equals =":
                            try
                            {
                                tblPatientTableAdapter.FillByDateOfBirthEquals(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Less than <":
                            try
                            {
                                tblPatientTableAdapter.FillByDateOfBirthLess(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Greater than >":
                            try
                            {
                                tblPatientTableAdapter.FillByDateOfBirthGreater(hospitalDataSet.tblPatient, txtSearch.Text);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                    }
                    break;
                case "InPatient":
                    switch (cboOperator.SelectedItem.ToString())
                    {
                        case "Equals =":
                            try
                            {
                                tblPatientTableAdapter.FillByInPatientEquals(hospitalDataSet.tblPatient, Convert.ToBoolean(txtSearch.Text));
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Less than <":
                            try
                            {
                                tblPatientTableAdapter.FillByInPatientEquals(hospitalDataSet.tblPatient, Convert.ToBoolean(txtSearch.Text));
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                        case "Greater than >":
                            try
                            {
                                tblPatientTableAdapter.FillByInPatientGreater(hospitalDataSet.tblPatient, Convert.ToBoolean(txtSearch.Text));
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Invalid search parameters. Please try again." + newline + "Original error: " + newline + ex);
                            }
                            break;
                    }
                    break;
            }
        }

        private void tblPatientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPatientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
        }
    }
}
