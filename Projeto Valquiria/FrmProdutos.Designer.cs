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
            btnHome.BackColor = Color.FromArgb(255, 226, 100);
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(14, 33);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 75);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dgvDadosProdutos
            // 
            dgvDadosProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDadosProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosProdutos.Location = new Point(402, 229);
            dgvDadosProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvDadosProdutos.Name = "dgvDadosProdutos";
            dgvDadosProdutos.RowHeadersWidth = 51;
            dgvDadosProdutos.Size = new Size(1048, 541);
            dgvDadosProdutos.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(142, 33);
            label1.TabIndex = 1;
            label1.Text = "Nome do produto";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 59);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 1;
            label2.Text = "Valor do Produto";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(190, 13);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: Bolo";
            txtNome.Size = new Size(383, 29);
            txtNome.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 10F);
            txtValor.Location = new Point(190, 55);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ex: 9,99";
            txtValor.Size = new Size(383, 30);
            txtValor.TabIndex = 2;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Location = new Point(611, 13);
            btnCadastroProduto.Margin = new Padding(3, 4, 3, 4);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(150, 56);
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
            panel1.Location = new Point(402, 805);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 104);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 925);
            panel2.TabIndex = 6;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCadastroCliente.FlatStyle = FlatStyle.Popup;
            btnCadastroCliente.ForeColor = Color.White;
            btnCadastroCliente.Location = new Point(70, 475);
            btnCadastroCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(181, 63);
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
            btnProduto.Location = new Point(70, 404);
            btnProduto.Margin = new Padding(3, 4, 3, 4);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(181, 63);
            btnProduto.TabIndex = 5;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(70, 333);
            btnPedido.Margin = new Padding(3, 4, 3, 4);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(181, 63);
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
            label3.Location = new Point(754, 33);
            label3.Name = "label3";
            label3.Size = new Size(425, 59);
            label3.TabIndex = 7;
            label3.Text = "Área de Cadastro de Produtos";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(505, 153);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(829, 27);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.FlatStyle = FlatStyle.Flat;
            btnEdicao.Location = new Point(1480, 229);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(65, 81);
            btnEdicao.TabIndex = 8;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(1494, 354);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1502, 406);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 226, 176);
            ClientSize = new Size(1637, 925);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEdicao);
            Controls.Add(txtPesquisar);
            Controls.Add(label3);
            Controls.Add(dgvDadosProdutos);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
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