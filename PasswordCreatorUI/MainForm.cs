using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCreatorUI
{
    public partial class MainForm : Form
    {
        private Controller controller;
        public MainForm()
        {
            InitializeComponent();
            controller = new Controller();
            NumOfLetters.Value = 12;
            NumOfLetters.Minimum = 10;
            NumOfLetters.Maximum = 32;
            this.Text = "Password Creator";
            Password.Font = new Font("Meiryo", 14);
            All.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumOfLetters_ValueChanged(object sender, EventArgs e)
        {
            controller.NumOfLetters = (int)NumOfLetters.Value;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            string pw = controller.MakePasssword();
            Password.Text = pw;
            Clipboard.SetText(pw);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            controller.IsAll = All.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            controller.IsNonMark = NonMark.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            controller.IsMark2 = Mark2.Checked;
        }
    }
}
