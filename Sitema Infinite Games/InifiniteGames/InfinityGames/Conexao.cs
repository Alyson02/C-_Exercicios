using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityGames
{
    class Conexao
    {

        SqlConnection cn = new SqlConnection(@"Data Source =  DESKTOP-VRHP59O\SQLEXPRESS; Initial Catalog = infinitegames6; Integrated Security = True");
        public static string msg;


        public SqlConnection Abrir()
        {

            try
            {
                cn.Open();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;

        }

        public SqlConnection Fechar()
        {
            try
            {
                cn.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;


        }
    }
}
