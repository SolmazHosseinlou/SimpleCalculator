using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HsCalculator
{
    public partial class Form1 : Form
    {
        ICalculate mycalc;

        public Form1()
        {
            InitializeComponent();
            mycalc = new HsCalculate();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int plus = mycalc.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل جمع = " + plus);
            }
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = mycalc.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل ضرب = " + multiple);
            }

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minus = mycalc.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل تفریق = " + minus);
            }
        }

        private void BtnDevide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int devide = mycalc.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("حاصل تقسیم = " + devide);
            }
        }
        bool ValidateInputs()
        {
            bool isValid = true;
            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("عدد اول را وارد نمایید!");
            }
            else
            {
                if (txtNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("عدد دوم را وارد نمایید!");
                }
            }
            return isValid;
        }
    }
}
