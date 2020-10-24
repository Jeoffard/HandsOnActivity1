using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form {



        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblGender.Text = StudentInformationClass.SetGender;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblAge.Text = StudentInformationClass.SetAge.ToString();
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
        }
    }
}
