using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luciano_caixa
{
    class conexao
    {
        //conectivos para entrada de dados para aplicação
        public string conec = "SERVER=localhost; DATABASE=pdv_d; UID=root; PWD=; PORT;";
        public MySqlConnection con = null;

        public void Abrirc()
        {
            con = new MySqlConnection(conec);
            con.Open();
        }

        public void Fecharc()
        {
            con.Close();
            con.Dispose(); //fecha conexões abertas que não estão sendo utilizadas
            con.ClearAllPoolsAsync(); //LIMPEZA 
        }
    }
}



