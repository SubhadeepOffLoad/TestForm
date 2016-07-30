using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add logic for sum of two numbers and output to the third textbox

            //Get Value 1
            string sValue1 = textBox1.Text; //Get the text value. this is always as string
            double dValue1 = Convert.ToDouble(sValue1); //convert to double 

            //Get Value 2
            string sValue2 = textBox2.Text; //Get the text value. this is always as string
            double dValue2 = Convert.ToDouble(sValue2); //convert to double 


            //Value 3 = Value 1 + Value 3
            double dValue3 = dValue1 + dValue2; //Add
            textBox3.Text = dValue3.ToString("#0.00"); //convert double value to string with 0.00 format

        }
    }
}
