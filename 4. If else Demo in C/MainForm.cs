using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace If_else_Demo_in_C
{
    public partial class MainForm : Form
    {
        public object ResultTextbox { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
            ResultTextBox.Clear();

            FirstNumberTextBox.Focus();
            AdditionRadioButton.Checked = true;

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int firstNum = int.Parse(FirstNumberTextBox.Text);
            int secondNum = int.Parse(SecondNumberTextBox.Text);
            int result = 0;
            if(AdditionRadioButton.Checked==true)
            {
                result = firstNum + secondNum;
            }
            if(SubtractionRadioButton.Checked==true)
            {
                result = firstNum - secondNum;
            }
            ResultTextBox.Text = result.ToString();
            if(result>100)
            {
                MessageBox.Show("Result is greater than 100");
            }
            else
            {
                MessageBox.Show("Result is lesser than 100");
            }
        }
    }
}
