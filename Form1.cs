using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc3
{
    public partial class form_Calc : Form
    {
        Double valor = 0;
        String operacao = "";
        bool oper_press = false;

        public form_Calc()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (oper_press))
                result.Clear();
            oper_press = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void btn_BckSpace_Click(object sender, EventArgs e)
        {
            if(result.Text.Length >0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);                
            }

            if (result.Text =="")
            {
                result.Text = "0";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            valor = 0;
        }

        private void btn_Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacao = b.Text;
            valor = Double.Parse(result.Text);
            oper_press = true;
            lbl_Eq.Text = valor + " " + operacao;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lbl_Eq.Text = "";
            switch (operacao)
            {
                case "+":
                    result.Text = (valor + Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (valor - Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (valor * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (valor / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            } //end switch
            oper_press = false;

        }

        private void btn_SqrRoot_Click(object sender, EventArgs e)
        {
            lbl_Eq.Text = "";
            switch (operacao)
            {
                case "√":
                    result.Text = (Math.Sqrt(valor)).ToString();
                    break;
            }
            oper_press = false;
        }

        
    }
}
