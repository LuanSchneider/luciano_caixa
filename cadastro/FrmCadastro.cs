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
   
        string alterar = "não";
        string cpfA;
      
        public FrmCadastro()
        {
            InitializeComponent();
        }
        static string funcionarios = "SERVER=127.0.0.1; PORT=3306;DATABASE=pdv_d;UID=root;PASSAWORDS=;";
        readonly MySqlConnection cn = new MySqlConnection(funcionarios);
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            alterar = "não";
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

            if (textnome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("preencha todos os campos", "cadastro dos funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textnome.Text = "";
                textnome.Focus();
                return;
            }
            if (textcpfm.Text == "   ,   ,   -" || textcpfm.Text.Length < 14)
            {
                MessageBox.Show("prenencha o campo de CPF", "cadastro dos funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textcpfm.Focus();
                return;
            }

            cn.Open();
            string insert = "INSERT INTO funcionarios(NOME,CPF,ENDEREÇO,TELEFONE,CARGO)values(@nome,@CPF,@endereço,@telefone,@cargo)";


            MySqlCommand cmd = new MySqlCommand(insert, cn);
            cmd.Parameters.AddWithValue("@nome", textnome.Text);
            cmd.Parameters.AddWithValue("@CPF", textcpfm.Text);
            cmd.Parameters.AddWithValue("@endereço", textendereço.Text);
            cmd.Parameters.AddWithValue("@telefone", textphone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbcf.Text);
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("salvo com sucesso");
            dataGridView1.DataSource = llenar_grid();

        }

        private void btne_Click(object sender, EventArgs e)
        {
            cn.Open();

            string editar = "UPDATE funcionarios SET  NOME=@nome,CPF=@cpf,ENDEREÇO=@endereço,TELEFONE=@telefone,CARGO=@cargo WHERE ID=@id ";
            MySqlCommand cmd = new MySqlCommand(editar, cn);
            
            cmd.Parameters.AddWithValue("@nome", textnome.Text);
            cmd.Parameters.AddWithValue("@CPF", textcpfm.Text);
            cmd.Parameters.AddWithValue("@endereço", textendereço.Text);
            cmd.Parameters.AddWithValue("@telefone", textphone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbcf.Text);
            MessageBox.Show("salvo com sucesso");
           
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("da");
            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textnome.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textcpfm.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textendereço.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textphone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbcf.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
            }

    }
}



