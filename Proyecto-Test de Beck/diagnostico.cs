using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Proyecto_Test_de_Beck
{
    public class diagnostico
    {
        public int idDiagnostico { get; set; }
        public double puntuacion { get; set; }
        public string descripcion { get; set; }
        public int idPaciente { get; set; }
        public int idTest { get; set; }

        public static int Insert_diagnostico(diagnostico diag)
        {
            try
            {
                using (IDbConnection db = new
                    SqlConnection(conexion.Conexion))
                {
                    var parametros = new DynamicParameters();
                    parametros.Add("@puntuacion", diag.puntuacion);
                    parametros.Add("@descripcion", diag.descripcion);
                    parametros.Add("@idPaciente", diag.idPaciente);
                    parametros.Add("@idTest", diag.idTest);

                    var id = db.Execute("insertarDiagnostico", parametros, commandType: CommandType.StoredProcedure);

                    return id;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static diagnostico diagno(int id1, int id2)
        {
            List<diagnostico> diax = new List<diagnostico>();
            try
            {
                using (IDbConnection db = new
                    SqlConnection(conexion.Conexion))
                {
                    var parametros = new DynamicParameters();
                    parametros.Add("@idPaciente", id1);
                    parametros.Add("@idtest", id2);

                    diax = db.Query<diagnostico>(
                        "traerDiagnostico",parametros, commandType: CommandType.StoredProcedure).ToList();
                }
                return diax[0];
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
