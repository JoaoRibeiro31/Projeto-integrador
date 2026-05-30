namespace Projeto_Valquiria
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            label1 = new Label();
            txtNome = new TextBox();
            txtContato = new TextBox();
            btnCliente = new Button();
            lblNome = new Label();
            lblContato = new Label();
            pnlCadastro = new Panel();
            dvgTabela = new DataGridView();
            panelMenu = new PictureBox();
            btnHome = new Button();
            btnProduto = new Button();
            btnClientes = new Button();
            btnPedido = new Button();
            button1 = new Button();
            button2 = new Button();
            txtPesquisar = new TextBox();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelMenu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(642, 19);
            label1.Name = "label1";
            label1.Size = new Size(361, 50);
            label1.TabIndex = 0;
            label1.Text = "Área de cadastro de clientes";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 11);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(661, 23);
            txtNome.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(76, 62);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(535, 23);
            txtContato.TabIndex = 1;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(631, 69);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(114, 23);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cadastrar Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.White;
            lblNome.Location = new Point(433, 568);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.White;
            lblContato.Location = new Point(423, 623);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(53, 15);
            lblContato.TabIndex = 5;
            lblContato.Text = "Contato:";
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(btnCliente);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Controls.Add(txtContato);
            pnlCadastro.Location = new Point(406, 554);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(772, 110);
            pnlCadastro.TabIndex = 6;
            // 
            // dvgTabela
            // 
            dvgTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTabela.Location = new Point(352, 140);
            dvgTabela.Name = "dvgTabela";
            dvgTabela.RowHeadersWidth = 51;
            dvgTabela.Size = new Size(917, 406);
            dvgTabela.TabIndex = 7;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(159, 214, 242);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(273, 694);
            panelMenu.TabIndex = 8;
            panelMenu.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(159, 214, 242);
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 25);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(53, 56);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnVoltar_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(61, 303);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(158, 47);
            btnProduto.TabIndex = 11;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(253, 208, 23);
            btnClientes.Cursor = Cursors.No;
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(61, 356);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(158, 47);
            btnClientes.TabIndex = 10;
            btnClientes.Text = "Cliente";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(61, 250);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(158, 47);
            btnPedido.TabIndex = 9;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(164, 92, 218);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(61, 250);
            button1.Name = "button1";
            button1.Size = new Size(158, 47);
            button1.TabIndex = 9;
            button1.Text = "Pedidos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(56, 206, 22);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(61, 303);
            button2.Name = "button2";
            button2.Size = new Size(158, 47);
            button2.TabIndex = 11;
            button2.Text = "Produtos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(417, 94);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(726, 23);
            txtPesquisar.TabIndex = 18;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.FlatStyle = FlatStyle.Flat;
            btnEdicao.Location = new Point(1315, 140);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(57, 61);
            btnEdicao.TabIndex = 19;
            btnEdicao.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(1317, 240);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1315, 269);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 20;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1432, 694);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEdicao);
            Controls.Add(txtPesquisar);
            Controls.Add(button2);
            Controls.Add(btnProduto);
            Controls.Add(btnClientes);
            Controls.Add(button1);
            Controls.Add(btnPedido);
            Controls.Add(btnHome);
            Controls.Add(dvgTabela);
            Controls.Add(lblContato);
            Controls.Add(lblNome);
            Controls.Add(label1);
            Controls.Add(pnlCadastro);
            Controls.Add(panelMenu);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmClientes_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtContato;
        private Button btnCliente;
        private Label lblNome;
        private Label lblContato;
        private Panel pnlCadastro;
        private DataGridView dvgTabela;
        private PictureBox panelMenu;
        private Button btnHome;
        private Button btnProduto;
        private Button btnClientes;
        private Button btnPedido;
        private Button button1;
        private Button button2;
        private TextBox txtPesquisar;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}