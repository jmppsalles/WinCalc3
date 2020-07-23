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


        //Cobre os botoes numéricos e de decimal
        private void btn_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (oper_press))
                result.Clear();
            oper_press = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        //Botão Back Space
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

        // botão CE
        private void button28_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

         // Botão C
        private void button27_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            valor = 0;
        }

        // Área das operções
        private void btn_Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacao = b.Text;
            valor = Double.Parse(result.Text);
            oper_press = true;
            lbl_Eq.Text = valor + " " + operacao;
        }


        //cobre o botão de "="
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

                case "^":
                    result.Text = (Math.Pow(valor, Double.Parse(result.Text))).ToString();
                    break;

                default:
                    break;
            } //end switch
            oper_press = false;

        }

        //Calcula raiz quadrada
        private void btn_SqrRoot_Click(object sender, EventArgs e)
        {
            Double sqr = Double.Parse(result.Text);
            lbl_Eq.Text = System.Convert.ToString("√ " + sqr);
            sqr = Math.Sqrt(sqr);
            result.Text = System.Convert.ToString(sqr);

        }

       //Calcula o quadrado do valor 
        private void btn_Sqr_Click(object sender, EventArgs e)
        {
            Double quad;
            lbl_Eq.Text = result.Text + "^2";
            quad = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(quad);
        }


        //Inverte sinal
        private void btn_InvertSign_Click(object sender, EventArgs e)
        {
            if(result.Text.StartsWith("-"))
            {
                result.Text = result.Text.Substring(1);
            }
            else
            {
                result.Text = "-" + result.Text;
            }
        }


        // calcula 1/x
        private void btn_Invert_Click(object sender, EventArgs e)
        {
            Double inv;
            lbl_Eq.Text = "1/" + result.Text;
            inv = Convert.ToDouble(1.0) / Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(inv);
        }
    }
}
