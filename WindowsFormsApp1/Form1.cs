using MCO368;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string input;
            input = inputTextBox.Text;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = NumberConversions.Convert(Convert.ToInt32(inputTextBox.Text));
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
            outputLabel.Text = NumberConversions.Convert(Convert.ToInt32(inputTextBox.Text));
        }
    }
}