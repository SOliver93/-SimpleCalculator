using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;

namespace DesktopCalculator
{
    public partial class Form1 : Form
    {
        public float fPrviBroj;
        public float fDrugiBroj;
        float rezultat = 0;
        Calculator Calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Add(fPrviBroj, fDrugiBroj));
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Substract(fPrviBroj, fDrugiBroj));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Multiply(fPrviBroj, fDrugiBroj));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Divide(fPrviBroj, fDrugiBroj));
        }
    }
}
