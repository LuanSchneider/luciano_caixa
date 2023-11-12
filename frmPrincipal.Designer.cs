
namespace luciano_caixa
{
    partial class frmprincipa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Menufuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuvendendor = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuprodutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menuestoque = new System.Windows.Forms.ToolStripMenuItem();
            this.Menucategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenufluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenulançarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuentradasaida = new System.Windows.Forms.ToolStripMenuItem();
            this.Menudespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuprodutoss = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuvendass = new System.Windows.Forms.ToolStripMenuItem();
            this.Menumovimentaçãoo = new System.Windows.Forms.ToolStripMenuItem();
            this.entradassaidass = new System.Windows.Forms.ToolStripMenuItem();
            this.despesass = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1,
            this.Menu2,
            this.Menu3,
            this.Menu4,
            this.sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu1
            // 
            this.Menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menuusuarios,
            this.Menufuncionario,
            this.Menuvendendor});
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(69, 20);
            this.Menu1.Text = "cadastros";
            // 
            // Menuusuarios
            // 
            this.Menuusuarios.Name = "Menuusuarios";
            this.Menuusuarios.Size = new System.Drawing.Size(180, 22);
            this.Menuusuarios.Text = "usuarios";
            // 
            // Menufuncionario
            // 
            this.Menufuncionario.Name = "Menufuncionario";
            this.Menufuncionario.Size = new System.Drawing.Size(180, 22);
            this.Menufuncionario.Text = "funcionario";
            this.Menufuncionario.Click += new System.EventHandler(this.Menufuncionario_Click);
            // 
            // Menuvendendor
            // 
            this.Menuvendendor.Name = "Menuvendendor";
            this.Menuvendendor.Size = new System.Drawing.Size(180, 22);
            this.Menuvendendor.Text = "fornecedor";
            // 
            // Menu2
            // 
            this.Menu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menuprodutos,
            this.toolStripSeparator1,
            this.Menuestoque,
            this.Menucategorias});
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(67, 20);
            this.Menu2.Text = "produtos";
            // 
            // Menuprodutos
            // 
            this.Menuprodutos.Name = "Menuprodutos";
            this.Menuprodutos.Size = new System.Drawing.Size(180, 22);
            this.Menuprodutos.Text = "produtos";
            this.Menuprodutos.Click += new System.EventHandler(this.Menuprodutos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // Menuestoque
            // 
            this.Menuestoque.Name = "Menuestoque";
            this.Menuestoque.Size = new System.Drawing.Size(128, 22);
            this.Menuestoque.Text = "estoque";
            // 
            // Menucategorias
            // 
            this.Menucategorias.Name = "Menucategorias";
            this.Menucategorias.Size = new System.Drawing.Size(128, 22);
            this.Menucategorias.Text = "categorias";
            // 
            // Menu3
            // 
            this.Menu3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenufluxoCaixa,
            this.MenulançarVenda,
            this.Menuentradasaida,
            this.Menudespesas});
            this.Menu3.Name = "Menu3";
            this.Menu3.Size = new System.Drawing.Size(99, 20);
            this.Menu3.Text = "Movimentação";
            // 
            // MenufluxoCaixa
            // 
            this.MenufluxoCaixa.Name = "MenufluxoCaixa";
            this.MenufluxoCaixa.Size = new System.Drawing.Size(146, 22);
            this.MenufluxoCaixa.Text = "fluxo caixa";
            // 
            // MenulançarVenda
            // 
            this.MenulançarVenda.Name = "MenulançarVenda";
            this.MenulançarVenda.Size = new System.Drawing.Size(146, 22);
            this.MenulançarVenda.Text = "lançar venda";
            // 
            // Menuentradasaida
            // 
            this.Menuentradasaida.Name = "Menuentradasaida";
            this.Menuentradasaida.Size = new System.Drawing.Size(146, 22);
            this.Menuentradasaida.Text = "entrada/saida";
            // 
            // Menudespesas
            // 
            this.Menudespesas.Name = "Menudespesas";
            this.Menudespesas.Size = new System.Drawing.Size(146, 22);
            this.Menudespesas.Text = "despesas";
            // 
            // Menu4
            // 
            this.Menu4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menuprodutoss,
            this.Menuvendass,
            this.Menumovimentaçãoo,
            this.entradassaidass,
            this.despesass});
            this.Menu4.Name = "Menu4";
            this.Menu4.Size = new System.Drawing.Size(66, 20);
            this.Menu4.Text = "Relatório";
            // 
            // Menuprodutoss
            // 
            this.Menuprodutoss.Name = "Menuprodutoss";
            this.Menuprodutoss.Size = new System.Drawing.Size(156, 22);
            this.Menuprodutoss.Text = "produtos";
            // 
            // Menuvendass
            // 
            this.Menuvendass.Name = "Menuvendass";
            this.Menuvendass.Size = new System.Drawing.Size(156, 22);
            this.Menuvendass.Text = "vendas";
            // 
            // Menumovimentaçãoo
            // 
            this.Menumovimentaçãoo.Name = "Menumovimentaçãoo";
            this.Menumovimentaçãoo.Size = new System.Drawing.Size(156, 22);
            this.Menumovimentaçãoo.Text = "movimentação";
            // 
            // entradassaidass
            // 
            this.entradassaidass.Name = "entradassaidass";
            this.entradassaidass.Size = new System.Drawing.Size(156, 22);
            this.entradassaidass.Text = "entradas/saidas";
            // 
            // despesass
            // 
            this.despesass.Name = "despesass";
            this.despesass.Size = new System.Drawing.Size(156, 22);
            this.despesass.Text = "despesas";
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(37, 20);
            this.sair.Text = "sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::luciano_caixa.Properties.Resources.WhatsApp_Image_2023_11_02_at_20_391;
            this.pictureBox1.Location = new System.Drawing.Point(663, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // img04
            // 
            this.img04.Image = global::luciano_caixa.Properties.Resources.icons8_produtos_50;
            this.img04.Location = new System.Drawing.Point(431, 300);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(74, 61);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img04.TabIndex = 5;
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::luciano_caixa.Properties.Resources.icons8_stock_32;
            this.img03.Location = new System.Drawing.Point(251, 300);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(80, 61);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img03.TabIndex = 4;
            this.img03.TabStop = false;
            // 
            // img01
            // 
            this.img01.BackgroundImage = global::luciano_caixa.Properties.Resources.img_icons8;
            this.img01.Image = global::luciano_caixa.Properties.Resources.img_icons8;
            this.img01.Location = new System.Drawing.Point(251, 179);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(80, 71);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img01.TabIndex = 3;
            this.img01.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::luciano_caixa.Properties.Resources.icons8_tag_de_preço_de_venda_64;
            this.img02.Location = new System.Drawing.Point(431, 179);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(74, 71);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img02.TabIndex = 1;
            this.img02.TabStop = false;
            // 
            // frmprincipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipa";
            this.Text = "    ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu1;
        private System.Windows.Forms.ToolStripMenuItem Menu2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu3;
        private System.Windows.Forms.ToolStripMenuItem Menu4;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Menuusuarios;
        private System.Windows.Forms.ToolStripMenuItem Menufuncionario;
        private System.Windows.Forms.ToolStripMenuItem Menuvendendor;
        private System.Windows.Forms.ToolStripMenuItem Menuprodutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menuestoque;
        private System.Windows.Forms.ToolStripMenuItem Menucategorias;
        private System.Windows.Forms.ToolStripMenuItem MenufluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenulançarVenda;
        private System.Windows.Forms.ToolStripMenuItem Menuentradasaida;
        private System.Windows.Forms.ToolStripMenuItem Menudespesas;
        private System.Windows.Forms.ToolStripMenuItem Menuprodutoss;
        private System.Windows.Forms.ToolStripMenuItem Menuvendass;
        private System.Windows.Forms.ToolStripMenuItem Menumovimentaçãoo;
        private System.Windows.Forms.ToolStripMenuItem entradassaidass;
        private System.Windows.Forms.ToolStripMenuItem despesass;
    }
}

