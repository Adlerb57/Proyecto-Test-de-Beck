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
    public partial class formResultado : Form
    {
        paciente currentPaciente;
        test currentTest;
        diagnostico currentDiax;
        public formResultado(paciente paciente1, test test1, diagnostico dia)
        {
            InitializeComponent();
            this.currentPaciente = paciente1;
            this.currentTest = test1;
            this.currentDiax = dia;
        }

        private void formResultado_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = currentPaciente.nombres;
            this.lblApellidos.Text = currentPaciente.apellidos;
            this.lblEdad.Text = currentPaciente.edad.ToString();
            this.lblemail.Text = currentPaciente.email;
            this.lblTelefono.Text = currentPaciente.telefono;
            this.lblfecha.Text = currentPaciente.fechaNacimiento.ToString();
            this.lblDiagnostico.Text = currentDiax.descripcion;
            this.lblPuntuacion.Text = currentDiax.puntuacion.ToString();
            if (currentDiax.puntuacion >= 17)
            {
                label9.Visible = true;
                label11.Visible = true;
            }
            else
            {
                label9.Visible = false;
                label11.Visible = false;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
