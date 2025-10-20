using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_a_File
{
    public partial class FileName : Form
    {
        public static string SetFileName;
        public FileName()
        {
            InitializeComponent();


        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

            string fileContent = txtInput.Text;
            string fileNameInput = txtFileName.Text.Trim();
            SetFileName = fileNameInput.EndsWith(".txt") ? fileNameInput : fileNameInput + ".txt";
            
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
            string folderPath = Path.Combine(projectRoot, "Files");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, SetFileName);

          
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(fileContent);
            }

           
            MessageBox.Show($"File created successfully in:\n{filePath}");

           
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.Show();
            this.Hide();
        }
    }
}
