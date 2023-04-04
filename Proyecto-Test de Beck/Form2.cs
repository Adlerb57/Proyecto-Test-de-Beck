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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rpta = MessageBox.Show("Esta seguro de guardar", "Test",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rpta.ToString() == "OK")
            {
                paciente pacient = new paciente();
                pacient.nombres = txtNombres.Text;
                pacient.apellidos = txtApellidos.Text;
                pacient.edad = Convert.ToInt32(txtEdad.Text); ;
                pacient.fechaNacimiento = dtpFechaNacimiento.Value.ToString();
                pacient.email = txtEmail.Text;
                pacient.telefono = txtTelefono.Text;

                int id = paciente.Insert_paciente(pacient);

                List<paciente> lista = new List<paciente>();
                lista = paciente.List_pacientes();
                paciente aux = new paciente();
                aux = lista.Last();
                int idPaciente = aux.idPaciente;
                Form3 fmr3 = new Form3(idPaciente);
                fmr3.Show();
                this.Hide();

            }


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
