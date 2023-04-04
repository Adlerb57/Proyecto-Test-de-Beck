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
    public partial class Form6 : Form
    {
        string rpta1 = "";
        string rpta2 = "";
        string rpta3 = "";
        string rpta4 = "";
        string rpta5 = "";
        string respuestas = "";
        int idPaciente = 0;
        paciente currentPaciente = new paciente();
        test currentTest = new test();
        diagnostico currentDiax = new diagnostico();
        public Form6(int ac1, int idPaciente, string respuestas)
        {
            InitializeComponent();
            this.ac1 = ac1;
            this.idPaciente=idPaciente;
            this.respuestas = respuestas;
        }
        int ac1;
        String mensaje="";
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonq1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonq2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonq3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonq4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            else if (radioButtonq5.Checked == true)
            {
                ac1 = ac1 + 4;
                rpta5 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 +rpta5+ ",";

            //*******************
            if (radioButtonr1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtonr2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta2 = "1";
            }
            else if (radioButtonr3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta3 = "1";
            }
            else if (radioButtonr4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta4 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";

            //********************
            if (radioButtons1.Checked == true)
            {
                ac1 = ac1 + 0;
                rpta1 = "1";
            }
            else if (radioButtons2.Checked == true)
            {
                ac1 = ac1 + 1;
                rpta1 = "1";
            }
            else if (radioButtons3.Checked == true)
            {
                ac1 = ac1 + 2;
                rpta1 = "1";
            }
            else if (radioButtons4.Checked == true)
            {
                ac1 = ac1 + 3;
                rpta1 = "1";
            }
            respuestas = respuestas + rpta1 + rpta2 + rpta3 + rpta4 + ",";
            rango();
        }
        public void rango()
        {
            //rango de niveles
            if (ac1>=0 && ac1 <= 10 )
            {
                mensaje = "Estos altibajos son considerados normales. ";
            }else if (ac1 >= 11 && ac1 <= 16)
            {
                mensaje = "Leve perturbación del estado de ánimo.  ";
            }
            else if (ac1 >= 17 && ac1 <= 20)
            {
                mensaje = "Estados de depresión intermitentes.  ";
            }
            else if (ac1 >= 21 && ac1 <= 30)
            {
                mensaje = "Depresión moderada.  ";
            }
            else if (ac1 >= 31 && ac1 <= 40)
            {
                mensaje = "Depresión grave. ";
            }else if (ac1>=41)
            {
                mensaje = "Depresión extrema. ";
            }

            textBox1.Text = mensaje;

            //guardar informacion
            test aux = new test();
            aux.idPaciente = idPaciente;
            aux.respuestas = respuestas;

            int id = test.Insert_test(aux);

            

            List<test> list = new List<test>();
            list = test.List_tests();
            int idTest = list.Last().idPaciente;
            currentTest = list.Find(x=>x.idTest == idTest);

            List<paciente> auxlist = new List<paciente>();
            auxlist = paciente.List_pacientes();
            currentPaciente = auxlist.Find(x=>x.idPaciente == idPaciente);




            //guardar diagnostico
            diagnostico diax = new diagnostico();
            diax.idPaciente = idPaciente;
            diax.puntuacion = ac1;
            diax.idTest = idTest;
            diax.descripcion = mensaje;

            int id2 = diagnostico.Insert_diagnostico(diax);
            MessageBox.Show("se a guardado con exito");

            List<diagnostico> auxlistdiax = new List<diagnostico>();
            currentDiax = diagnostico.diagno(idPaciente, idTest);

            formResultado formresultado = new formResultado(currentPaciente,currentTest, currentDiax);
            formresultado.Show();
            this.Hide();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
