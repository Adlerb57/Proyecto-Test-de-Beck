using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Windows.Forms;

namespace Proyecto_Test_de_Beck
{
    public class paciente
    {
        public int idPaciente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string fechaNacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }

        public static int Insert_paciente(paciente paciente)
        {
            try
            {
                using (IDbConnection db = new
                    SqlConnection(conexion.Conexion))
                {
                    var parametros = new DynamicParameters();
                    parametros.Add("@idPaciente", value: paciente.idPaciente, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                    parametros.Add("@nombres", paciente.nombres);
                    parametros.Add("@apellidos", paciente.apellidos);
                    parametros.Add("@edad", paciente.edad);
                    parametros.Add("@fechaNacimiento", paciente.fechaNacimiento);
                    parametros.Add("@email", paciente.email);
                    parametros.Add("@telefono", paciente.telefono);


                    var id = db.Execute("InsertarPaciente", parametros, commandType: CommandType.StoredProcedure);

                    return id;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static List<paciente> List_pacientes()
        {
            List<paciente> listClientes = new List<paciente>();
            try
            {
                using (IDbConnection db = new
                    SqlConnection(conexion.Conexion))
                {
                    var parametros = new DynamicParameters();

                    listClientes = db.Query<paciente>(
                        "listar_pacientes", commandType: CommandType.StoredProcedure).ToList();
                }
                return listClientes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
