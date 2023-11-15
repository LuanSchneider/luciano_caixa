using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luciano_caixa.cadastro
{
    public partial class FrmCadastro : Form
    {
        conexao con = new conexao();
        string  Sql;
        MySqlCommand cmd;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btns_Click(object sender, EventArgs e)
        {
            con.Abrirc();

            Sql = "INSERT INTO funcionarios(nome,CPF,endereço,telefone,cargo,)VALUEs=@nome,@CPF,@endereço,,@telefone,@cargo,";
            cmd = new MySqlCommand(Sql, con.con);
            cmd.Parameters.AddWithValue("@nome", textnome.Text);
            cmd.Parameters.AddWithValue("@CPF", textcpf.Text);
            cmd.Parameters.AddWithValue("@endereço", textendereço.Text);
            cmd.Parameters.AddWithValue("@telefone", textendereço.Text);
            cmd.Parameters.AddWithValue("@cargo", cbcf.SelectedItem);
           




            cmd.ExecuteNonQuery();
            con.Fecharc();
        }
    }
}
