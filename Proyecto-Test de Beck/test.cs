using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Test_de_Beck
{
    public class test
    {
        public int idTest { get; set; }
        public int idPaciente { get; set; }
        public string respuestas { get; set; }
        public static int Insert_test(test testing)
        {
            try
            {
                using (IDbConnection db = new
                    SqlConnection(conexion.Conexion))
                {
                    var parametros = new DynamicParameters();
                    parametros.Add("@idPaciente", testing.idPaciente);
                    parametros.Add("@respuesta", testing.respuestas);

                    var id = db.Execute("insertarTest", parametros, commandType: CommandType.StoredProcedure);

                    return id;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static List<test> List_tests()
        {
            List<test> listtests = new List<test>();
            try
            {
                using (IDbConnection db = new
                    SqlConnection(conexion.Conexion))
                {
                    var parametros = new DynamicParameters();

                    listtests = db.Query<test>(
                        "listartests", commandType: CommandType.StoredProcedure).ToList();
                }
                return listtests;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
