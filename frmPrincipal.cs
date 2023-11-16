using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luciano_caixa
{
    public partial class frmprincipa : Form
    {
        public frmprincipa()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menufuncionario_Click(object sender, EventArgs e)
        {
            cadastro.FrmCadastro frm = new cadastro.FrmCadastro();
            frm.Show();

        }

        private void Menuprodutos_Click(object sender, EventArgs e)
        {
            produtos.frmprodutos frm = new produtos.frmprodutos();
            frm.Show();
        }
    }
}



