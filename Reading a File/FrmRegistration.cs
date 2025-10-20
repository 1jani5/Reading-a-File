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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.WhiteSmoke);

            cbProgram.Items.AddRange(new string[]
{
    "BS Computer Science",
    "BS Information Technology",
    "BS Information Systems",
    "BS Software Engineering",
    "BS Data Science",
    "BS Civil Engineering",
    "BS Electrical Engineering",
    "BS Mechanical Engineering",
    "BS Architecture",
    "BS Accountancy",
    "BS Business Administration",
    "BS Marketing Management",
    "BS Psychology",
    "BS Nursing",
    "BS Medical Technology",
    "BS Pharmacy",
    "BS Biology",
    "BS Mathematics",
    "BA Communication",
    "BA Political Science",
    "BA Economics",
    "BA English Language Studies",
    "Bachelor of Elementary Education",
    "Bachelor of Secondary Education"
});

            if (cbProgram.Items.Count > 0)
                cbProgram.SelectedIndex = 0;

            cbGender.Items.AddRange(new string[]
             {
    "Male",
    "Famale"
             });

            if (cbGender.Items.Count > 0)
                cbGender.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.Show();
            this.Hide();
        }
    }
}
