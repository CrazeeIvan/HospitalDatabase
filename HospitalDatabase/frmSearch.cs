﻿using System;
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
        }

        private void tblPatientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPatientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
        }
    }
}
