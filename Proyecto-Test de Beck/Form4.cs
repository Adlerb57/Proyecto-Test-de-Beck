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
    public partial class Form4 : Form
    {
        string respuestas;
        int idPaciente;
        string rpta1 = "";
        string rpta2 = "";
        string rpta3 = "";
        string rpta4 = "";
        public Form4(int ac1, int idPaciente, string respuestas)
        {
            InitializeComponent();
            this.ac1 = ac1;
            this.idPaciente = idPaciente;
            this.respuestas = respuestas;
        }
        int ac1;

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (radioButtong1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtong2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtong3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtong4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //-----------------

            if (radioButtonh1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonh2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonh3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonh4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //------------------
            if (radioButtoni1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtoni2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtoni3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtoni4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //----------------------------------
            if (radioButtonj1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonj2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonj3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonj4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";


            //-----------------------

            if (radioButtonk1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonk2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonk3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonk4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //--------------------------------------
            if (radioButtonl1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonl2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonl3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonl4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";
            Form5 frm5 = new Form5(ac1, idPaciente, respuestas);
            frm5.Show();
            this.Hide();
  
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
