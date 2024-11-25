using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var operand1 = Convert.ToDouble(this.operand1.Text);
            var operand2 = Convert.ToDouble(this.operand2.Text);

            var result = operand1 + operand2;
            this.result.Text = result.ToString();


        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            var operand1 = Convert.ToDouble(this.operand1.Text);
            var operand2 = Convert.ToDouble(this.operand2.Text);

            var result = operand1 - operand2;
            this.result.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var operand1 = Convert.ToDouble(this.operand1.Text);
            var operand2 = Convert.ToDouble(this.operand2.Text);

            var result = operand1 * operand2;
            this.result.Text = result.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            var operand1 = Convert.ToDouble(this.operand1.Text);
            var operand2 = Convert.ToDouble(this.operand2.Text);

            var result = operand1 / operand2;
            this.result.Text = result.ToString();
        }

        private void operand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar) && (e.KeyChar !='.'))
            {
                e.Handled = true;
            }
            if(e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void operand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
