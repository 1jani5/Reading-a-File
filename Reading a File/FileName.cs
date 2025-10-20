using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_a_File
{
    public partial class FileName : Form
    {
        public FileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.Show();   
            this.Hide();
        }
    }
}
