using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace Sales_System
{
    public partial class Calculator : Form
    {
        double storedvalue = 0; // Tutorial
        string symbol = ""; // Tutorial
        bool pressed = false; // Tutorial

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "0";
        }

        private void btnClick(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "0" || pressed)
            {
                txtAnswer.Clear();
            }

            pressed = false;
            Button Response = (Button)sender;
            txtAnswer.Text = txtAnswer.Text + Response.Text;




        }

      

   

        private void btnC_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "0";
            storedvalue = 0;
           
        }

       

        private void Operator_Event(object sender, EventArgs e)
        {



            Button Response = (Button)sender;
            symbol = Response.Text;
            storedvalue = double.Parse(txtAnswer.Text);
            pressed = true;

          
            
        }

        // Tutorial End

        private void Operations_Event(object sender, EventArgs e)
        {
            if (symbol == "+")
            {
                double val = OperatorFunction.Add(storedvalue, double.Parse(txtAnswer.Text));
                txtAnswer.Text = Convert.ToString(val);
            }

            else if (symbol == "-")
            {
                double val = OperatorFunction.Subtract(storedvalue, double.Parse(txtAnswer.Text));
                txtAnswer.Text = Convert.ToString(val);
            }

            else if (symbol == "÷")
            {
                double val = OperatorFunction.Divide(storedvalue, double.Parse(txtAnswer.Text));
                txtAnswer.Text = Convert.ToString(val);
            }

            else if (symbol == "X")
            {
                double val = OperatorFunction.Multiply(storedvalue, double.Parse(txtAnswer.Text));
                txtAnswer.Text = Convert.ToString(val);
            }

            else if (symbol == "^")
            {
                double val = OperatorFunction.Power(storedvalue, double.Parse(txtAnswer.Text));
                txtAnswer.Text = Convert.ToString(val);
            }

            else if (symbol == "√ ")
            {
                double val = OperatorFunction.Root(storedvalue);
                txtAnswer.Text = Convert.ToString(val);
            }


            pressed = false;//Tutorial

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtAnswer.Text);
        }

     
        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
