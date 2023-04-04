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
    public partial class formLista : Form
    {
        List<paciente> pacientes;

        public formLista()
        {
            InitializeComponent();
        }

        private void formLista_Load(object sender, EventArgs e)
        {
            pacientes = paciente.List_pacientes();
            bindingSource.DataSource = pacientes;
        }

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells[0].Value);
            paciente currentPaciente = pacientes.Find(x=>x.idPaciente == idPaciente);

            List<test> lista = new List<test>();

            lista = test.List_tests();
            test currentTest = lista.Find(x=>x.idPaciente == idPaciente);

            List<diagnostico> auxlistdiax = new List<diagnostico>();
            diagnostico currentDiax = diagnostico.diagno(idPaciente, currentTest.idTest);
            formResultado formresultado = new formResultado(currentPaciente, currentTest, currentDiax);
            formresultado.ShowDialog();
            

        }
    }
}
