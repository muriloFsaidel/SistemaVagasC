using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaVagas
{
    class SQLServerOperations
    {

        string ConectionString;

        public SQLServerOperations(string connection)
        {
            this.ConectionString = connection;
        }

        public void inserirVaga(String cargo, String faixa_salarial, String requisitos, String escolaridade_minima, String email_empresa)
        {
            SqlConnection connection = new SqlConnection(ConectionString);

            String instrucao = "INSERT INTO vaga VALUES('"+cargo.ToString().Trim()+"','"+faixa_salarial.ToString().Trim()+"','"+requisitos.ToString().Trim()+"', '"+escolaridade_minima.ToString().Trim()+"','"+email_empresa.ToString().Trim() + "')";

            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(instrucao,connection);
                sqlCommand.ExecuteNonQuery();
            }

            catch ( Exception e)
            {
                throw e;
            }

            finally
            {
                connection.Close();
            }
        }


        public void alterarVaga(String cargoSql,String cargo, String faixa_salarial, String requisitos, String escolaridade_minima, String email_empresa)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionString);

            String instrucao = "UPDATE vaga SET cargo ='"+cargo.Trim() + "', faixa_salarial='"+faixa_salarial.Trim() + "', requisitos='"+requisitos.Trim() + "'," +
                "escolaridade_minima= '"+escolaridade_minima.Trim() + "', email_empresa= '"+email_empresa.Trim() + "'  WHERE cargo= '"+cargoSql.Trim()+ "'" ;

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(instrucao,sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        
    }
}
