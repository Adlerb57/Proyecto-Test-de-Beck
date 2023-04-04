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
    public partial class Form5 : Form
    {
        string rpta1 = "";
        string rpta2 = "";
        string rpta3 = "";
        string rpta4 = "";
        string respuestas = "";
        int idPaciente =0;
        public Form5(int ac1, int idPaciente , string respuestas)
        {
            InitializeComponent();
            this.ac1 = ac1;
            this.idPaciente = idPaciente;
            this.respuestas = respuestas;
        }
        int ac1;
        private void button1_Click(object sender, EventArgs e)
        {
            //----------- 
            if (radioButtongl1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtongl2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtongl3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtongl4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //_-------------
            if (radioButtonm1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonm2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonm3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonm4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //------------------------------
            if (radioButtonn1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonn2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonn3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonn4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //--------------------------------
            if (radioButtonñ1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonñ2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonñ3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonñ4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";


            //----------------------------------
            if (radioButtono1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtono2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtono3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtono4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //--------------------------
            if (radioButtonp1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonp2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonp3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonp4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";
            Form6 frm6 = new Form6(ac1,idPaciente, respuestas);
            frm6.Show();
            this.Hide();
        }

        private void radioButtonh3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
