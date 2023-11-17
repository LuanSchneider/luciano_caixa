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
      
        public FrmCadastro()
        {
            InitializeComponent();
        }
        static string funcionarios = "SERVER=127.0.0.1; PORT=3306;DATABASE=pdv_d;UID=root;PASSAWORDS=;";
      
        MySqlConnection cn = new MySqlConnection(funcionarios);
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
             dataGridView1.DataSource = llenar_grid();
        }
       
        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llener = "SELECT * FROM funcionarios";
            MySqlCommand cmd = new MySqlCommand(llener, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
             da.Fill(dt);
             cn.Close();

            return (dt);
        }

        private void btns_Click(object sender, EventArgs e)
        {
            cn.Open();
            string insert= "INSERT INTO funcionarios(NOME,CPF,ENDEREÇO,TELEFONE,CARGO)values(@nome,@CPF,@endereço,@telefone,@cargo)";


            MySqlCommand cmd = new MySqlCommand(insert,cn);
            cmd.Parameters.AddWithValue("@nome", textnome.Text);
            cmd.Parameters.AddWithValue("@CPF", textcpf.Text);
            cmd.Parameters.AddWithValue("@endereço", textendereço.Text);
            cmd.Parameters.AddWithValue("@telefone", texttw.Text);
            cmd.Parameters.AddWithValue("@cargo", cbcf.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            
            MessageBox.Show("salvo com sucesso");
            dataGridView1.DataSource = llenar_grid();
      
        }
    }
    }
