
using System.ComponentModel;

namespace luciano_caixa.cadastro
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textendereço = new System.Windows.Forms.TextBox();
            this.cbcf = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btns = new System.Windows.Forms.Button();
            this.btnee = new System.Windows.Forms.Button();
            this.btne = new System.Windows.Forms.Button();
            this.btnn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textcpfm = new System.Windows.Forms.MaskedTextBox();
            this.textphone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone/whatsapp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo do funcionnario";
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(75, 22);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(162, 20);
            this.textnome.TabIndex = 6;
            // 
            // textendereço
            // 
            this.textendereço.Location = new System.Drawing.Point(93, 82);
            this.textendereço.Name = "textendereço";
            this.textendereço.Size = new System.Drawing.Size(162, 20);
            this.textendereço.TabIndex = 7;
            // 
            // cbcf
            // 
            this.cbcf.FormattingEnabled = true;
            this.cbcf.Location = new System.Drawing.Point(490, 19);
            this.cbcf.Name = "cbcf";
            this.cbcf.Size = new System.Drawing.Size(121, 21);
            this.cbcf.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(802, 220);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btns
            // 
            this.btns.BackColor = System.Drawing.Color.SeaShell;
            this.btns.Location = new System.Drawing.Point(12, 428);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(75, 23);
            this.btns.TabIndex = 13;
            this.btns.Text = "salvar";
            this.btns.UseVisualStyleBackColor = false;
            this.btns.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnee
            // 
            this.btnee.BackColor = System.Drawing.Color.SeaShell;
            this.btnee.Location = new System.Drawing.Point(237, 428);
            this.btnee.Name = "btnee";
            this.btnee.Size = new System.Drawing.Size(75, 23);
            this.btnee.TabIndex = 14;
            this.btnee.Text = "Escluir";
            this.btnee.UseVisualStyleBackColor = false;
            // 
            // btne
            // 
            this.btne.BackColor = System.Drawing.Color.SeaShell;
            this.btne.Location = new System.Drawing.Point(156, 428);
            this.btne.Name = "btne";
            this.btne.Size = new System.Drawing.Size(75, 23);
            this.btne.TabIndex = 15;
            this.btne.Text = "Editar";
            this.btne.UseVisualStyleBackColor = false;
            this.btne.Click += new System.EventHandler(this.btne_Click);
            // 
            // btnn
            // 
            this.btnn.BackColor = System.Drawing.Color.SeaShell;
            this.btnn.Location = new System.Drawing.Point(75, 428);
            this.btnn.Name = "btnn";
            this.btnn.Size = new System.Drawing.Size(75, 23);
            this.btnn.TabIndex = 16;
            this.btnn.Text = "  novo";
            this.btnn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 15);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textcpfm
            // 
            this.textcpfm.Location = new System.Drawing.Point(458, 75);
            this.textcpfm.Mask = "000.000.000-00";
            this.textcpfm.Name = "textcpfm";
            this.textcpfm.Size = new System.Drawing.Size(100, 20);
            this.textcpfm.TabIndex = 19;
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(131, 53);
            this.textphone.Mask = "(99) 00000-0000";
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(100, 20);
            this.textphone.TabIndex = 20;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.textcpfm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnn);
            this.Controls.Add(this.btne);
            this.Controls.Add(this.btnee);
            this.Controls.Add(this.btns);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbcf);
            this.Controls.Add(this.textendereço);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastro";
            this.Text = "x";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textendereço;
        private System.Windows.Forms.ComboBox cbcf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btnee;
        private System.Windows.Forms.Button btne;
        private System.Windows.Forms.Button btnn;
        private System.Windows.Forms.Button button2;
        private ISupportInitialize pictureBox1;

        public FrmCadastro(ISupportInitialize pictureBox1)
        {
            this.pictureBox1 = pictureBox1;
        }

        private System.Windows.Forms.MaskedTextBox textcpfm;
        private System.Windows.Forms.MaskedTextBox textphone;
    }
}