using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Test_de_Beck
{
    public partial class Form3 : Form
    {
        public int idPaciente;
        string respuestas = "";
        string rpta1 = "0";
        string rpta2 = "";
        string rpta3 = "";
        string rpta4 = "";
        public Form3(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
        }
        int ac1 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //primera pregunta
            if (radioButton1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButton2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1" ;
            }
            else if (radioButton3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButton4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3+ rpta4+ ",";
            //segunda pregunta
            if (radioButton6.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButton7.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButton8.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButton9.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //tercera pregunta

            if (radioButtonc1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonc2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonc3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonc4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //cuarta pregunta
            if (radioButtond1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtond2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtond3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtond4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";
            //quinta pregunta

            if (radioButtone1.Checked == true)
            {
                ac1 = ac1 + 0;
                    rpta1 = "1";
                }
            else if (radioButtone2.Checked == true)
            {
                ac1 = ac1 + 1;
                    rpta2 = "1";
                }
            else if (radioButtone3.Checked == true)
            {
                ac1 = ac1 + 2;
                    rpta3 = "1";
                }
            else if (radioButtone4.Checked == true)
            {
                ac1 = ac1 + 3;
                    rpta4 = "1";
                }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";
            //sexta pregunta

            if (radioButtonf1.Checked == true)
            {
                ac1 = ac1 + 0;
                    rpta1 = "1";
                }
            else if (radioButtonf2.Checked == true)
            {
                ac1 = ac1 + 1;
                    rpta2 = "1";
                }
            else if (radioButtonf3.Checked == true)
            {
                ac1 = ac1 + 2;
                    rpta3 = "1";
                }
            else if (radioButtonf4.Checked == true)
            {
                ac1 = ac1 + 3;
                    rpta4 = "1";
                }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";
            
            Form4 fmr4 = new Form4(ac1, idPaciente, respuestas);
            fmr4.Show();
            this.Hide();
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
