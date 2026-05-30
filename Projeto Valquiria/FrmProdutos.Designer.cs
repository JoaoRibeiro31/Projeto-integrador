namespace Projeto_Valquiria
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            btnHome = new Button();
            dgvDadosProdutos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtValor = new TextBox();
            btnCadastroProduto = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCadastroCliente = new Button();
            btnProduto = new Button();
            btnPedido = new Button();
            label3 = new Label();
            txtPesquisar = new TextBox();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.None;
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(12, 25);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(53, 56);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dgvDadosProdutos
            // 
            dgvDadosProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDadosProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosProdutos.Location = new Point(352, 172);
            dgvDadosProdutos.Name = "dgvDadosProdutos";
            dgvDadosProdutos.RowHeadersWidth = 51;
            dgvDadosProdutos.Size = new Size(917, 406);
            dgvDadosProdutos.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do produto";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 44);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 1;
            label2.Text = "Valor do Produto";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(166, 10);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: Bolo";
            txtNome.Size = new Size(335, 25);
            txtNome.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 10F);
            txtValor.Location = new Point(166, 41);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ex: 9,99";
            txtValor.Size = new Size(335, 25);
            txtValor.TabIndex = 2;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Location = new Point(535, 10);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(131, 42);
            btnCadastroProduto.TabIndex = 3;
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCadastroProduto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(352, 604);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 78);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(159, 214, 242);
            panel2.Controls.Add(btnCadastroCliente);
            panel2.Controls.Add(btnProduto);
            panel2.Controls.Add(btnPedido);
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 694);
            panel2.TabIndex = 6;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCadastroCliente.FlatStyle = FlatStyle.Popup;
            btnCadastroCliente.ForeColor = Color.White;
            btnCadastroCliente.Location = new Point(61, 356);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(158, 47);
            btnCadastroCliente.TabIndex = 6;
            btnCadastroCliente.Text = "Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.Cursor = Cursors.No;
            btnProduto.Enabled = false;
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(61, 303);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(158, 47);
            btnProduto.TabIndex = 5;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(61, 250);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(158, 47);
            btnPedido.TabIndex = 4;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(660, 25);
            label3.Name = "label3";
            label3.Size = new Size(372, 44);
            label3.TabIndex = 7;
            label3.Text = "Área de Cadastro de Produtos";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(442, 115);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(726, 23);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.FlatStyle = FlatStyle.Flat;
            btnEdicao.Location = new Point(1295, 172);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(57, 61);
            btnEdicao.TabIndex = 8;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(1295, 275);
            btnAtualizar.Margin = new Padding(3, 2, 3, 2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(82, 22);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1295, 303);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(82, 22);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 226, 176);
            ClientSize = new Size(1432, 694);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEdicao);
            Controls.Add(txtPesquisar);
            Controls.Add(label3);
            Controls.Add(dgvDadosProdutos);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            WindowState = FormWindowState.Maximized;
            Load += FrmProdutos_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private DataGridView dgvDadosProdutos;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtValor;
        private Button btnCadastroProduto;
        private Panel panel1;
        private Panel panel2;
        private Button btnCadastroCliente;
        private Button btnProduto;
        private Button btnPedido;
        private Label label3;
        private TextBox txtPesquisar;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}