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
        float iCel2Fahr, iFahr2Cel, iCel2Kel, iFahr2Kel;
        char iOperation;

        public form_Calc()
        {
            InitializeComponent();
        }

        // configura o tamanho inicial do form
        private void form_Calc_Load(object sender, EventArgs e)
        {
            this.Width = 260;
            result.Width = 214;
        }
        // configura o tamanho do form para calc standard
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 260;
            result.Width = 214;
        }

        // configura o tamanho do form para calc Cientifica
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 500;
            result.Width = 457;
        }

        // configura o tamanho do form para menu Temperatura, Conversão de Unidade e Tabuada
        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 900;
            result.Width = 457;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 900;
            result.Width = 457;
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 900;
            result.Width = 457;
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
            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }

            if (result.Text == "")
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
            lbl_Eq.Text = "";
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

                case "Mod":
                    result.Text = (valor % Double.Parse(result.Text)).ToString();
                    break;

                case "Exp":
                   
                    result.Text = Math.Exp(valor).ToString();
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
            if (result.Text.StartsWith("-"))
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

        private void btn_PI_Click(object sender, EventArgs e)
            //Retorna PI com 20 casas decimais
        {
            result.Text = "3,14159265358979323846";
        }

        private void btn_Log_Click(object sender, EventArgs e)
            //Calcula Log base 10
        {

            lbl_Eq.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            double iLog = Double.Parse(result.Text);
            iLog = Math.Log10(iLog);
            result.Text = System.Convert.ToString(iLog);
        }

        private void btn_Sinh_Click(object sender, EventArgs e)
        //Calcula Seno hiperbólico
        {
            lbl_Eq.Text = System.Convert.ToString("Sinh" + "(" + (result.Text) + ")");
            double Sinh = Double.Parse(result.Text);
            Sinh = Math.Sinh(Sinh);
            result.Text = System.Convert.ToString(Sinh);
        }

        private void btn_Cosh_Click(object sender, EventArgs e)
        //Calcula Cosseno hiperbolico
        {
            lbl_Eq.Text = System.Convert.ToString("Cosh" + "(" + (result.Text) + ")");
            double Cosh = Double.Parse(result.Text);
            Cosh = Math.Cosh(Cosh);
            result.Text = System.Convert.ToString(Cosh);
        }

        private void btn_Tanh_Click(object sender, EventArgs e)
        //Calcula Tangente hiperbolica
        {
            lbl_Eq.Text = System.Convert.ToString("Tanh" + "(" + (result.Text) + ")");
            double Tanh = Double.Parse(result.Text);
            Tanh = Math.Tanh(Tanh);
            result.Text = System.Convert.ToString(Tanh);
        }

        private void btn_Sin_Click(object sender, EventArgs e)
        //Calcula Seno em Radianos
        {
            lbl_Eq.Text = System.Convert.ToString("Sin" + "(" + (result.Text) + ")");
            double Sin = Double.Parse(result.Text);            
            Sin = Math.Sin(Sin);
            result.Text = System.Convert.ToString(Sin);
        }

        private void btn_Cos_Click(object sender, EventArgs e)
        //Calcula Cosseno em Radianos
        {
            lbl_Eq.Text = System.Convert.ToString("Cos" + "(" + (result.Text) + ")");
            double Cos = Double.Parse(result.Text);
            Cos = Math.Cos(Cos);
            result.Text = System.Convert.ToString(Cos);
        }

        private void btn_Tan_Click(object sender, EventArgs e)
            //Calcula Tangente em Radianos
        {
            lbl_Eq.Text = System.Convert.ToString("Tan" + "(" + (result.Text) + ")");
            double Tan = Double.Parse(result.Text);
            Tan = Math.Tan(Tan);
            result.Text = System.Convert.ToString(Tan);
        }

        private void btn_Bin_Click(object sender, EventArgs e)
            //expressa numero em padrão binário
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 2);
        }

        private void btn_Hex_Click(object sender, EventArgs e)
            //expressa numero em padrão hexadecimal
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 16);
        }

        private void btn_Oct_Click(object sender, EventArgs e)
            //expressa numero em padrão Octo
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 8);
        }

        private void btn_Dec_Click(object sender, EventArgs e)
            //serve pra porra nenhuma
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void btn_LogNat_Click(object sender, EventArgs e)
            //LogNatural
        {
            lbl_Eq.Text = System.Convert.ToString("ln" + "(" + (result.Text) + ")");
            double iLogn = Double.Parse(result.Text);
            iLogn = Math.Log(iLogn);
            result.Text = System.Convert.ToString(iLogn);
        }

        private void btn_Percent_Click(object sender, EventArgs e)
            //Percentual
        {
            Double perc = Double.Parse(result.Text);
            perc = Convert.ToDouble(result.Text) / Convert.ToDouble(100);
            result.Text = System.Convert.ToString(perc);
        }

        private void radbtn_fahr2cels_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void radbtn_Kelvin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'J';
        }

        private void radbtn_cels2fahr_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void btn_TempConvert_Click(object sender, EventArgs e)
        {
            //  float iCel2Fahr, iFahr2Cel, iCel2Kel, iFahr2Kel;
            switch (iOperation)
            {
                case 'C':
                    //Celsius to Fahrenheit
                    iCel2Fahr = float.Parse(Conv_TxtBox.Text);
                    result_txtBox.Text = (((( iCel2Fahr * 9)/5) + 32).ToString());
                    break;

                case 'F':
                    //Fahrenheit to Celsius
                    iFahr2Cel = float.Parse(Conv_TxtBox.Text);
                    result_txtBox.Text = ((((iFahr2Cel - 32) * 5)/9).ToString());
                    break;

                case 'J':
                    //Celsius to Kelvin
                    iCel2Kel = float.Parse(Conv_TxtBox.Text);
                    result_txtBox.Text = ((iCel2Kel + 273.15).ToString());
                    break;

                case 'K':
                    //Fahrenheit to Kelvin
                    iFahr2Kel = float.Parse(Conv_TxtBox.Text);
                    result_txtBox.Text = ((((iFahr2Kel - 32)*5/9)+273.15).ToString());
                    break;
            }
        }
        private void btn_TempReset_Click(object sender, EventArgs e)
        {
            Conv_TxtBox.Clear();
            result_txtBox.Clear();
            radbtn_cels2fahr.Checked = false;
            radbtn_fahr2cels.Checked = false;
            radbtn_Far2Kelv.Checked = false;
            rdbtn_Cel2Kelv.Checked = false;


        }
    }
}
