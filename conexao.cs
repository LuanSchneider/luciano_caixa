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
        public string conec = "SERVER=localhost; DATABASE=PDV_D; UID=root PWD=;port;";
        public MySqlConnection con = null;
     public void Abrirc()
        {
            con = new MySqlConnection(conec);
            con.Open();
        }
       public void Fecharc()
        { 
            con = new MySqlConnection(conec);
            con.Close();
            con.Dispose(); //fecha coneXOES ABERTAS QUE NÃO ESTÃO SEMDO UTILIZADASA
            con.ClearAllPoolsAsync(); //LIMPEZA 

        }
    }

}
