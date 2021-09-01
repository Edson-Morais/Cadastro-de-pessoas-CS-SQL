using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_3_CAMADAS
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-7T95571\SQLEXPRESS;Initial Catalog=TESTE;Integrated Security=True";//password se tiver asteriscos colocar a senha
        }

        //metodo conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        //metodo desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
