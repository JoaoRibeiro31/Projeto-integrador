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
            label1 = new Label();
            txtNome = new TextBox();
            txtContato = new TextBox();
            btnCliente = new Button();
            lblNome = new Label();
            lblContato = new Label();
            pnlCadastro = new Panel();
            dvgTabela = new DataGridView();
            panelMenu = new PictureBox();
            btnVoltar = new Button();
            btnProduto = new Button();
            btnDados = new Button();
            btnPedido = new Button();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelMenu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
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
            lblNome.Location = new Point(419, 480);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.White;
            lblContato.Location = new Point(409, 535);
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
            pnlCadastro.Location = new Point(392, 466);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(772, 110);
            pnlCadastro.TabIndex = 6;
            // 
            // dvgTabela
            // 
            dvgTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTabela.Location = new Point(392, 87);
            dvgTabela.Name = "dvgTabela";
            dvgTabela.RowHeadersWidth = 51;
            dvgTabela.Size = new Size(901, 358);
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
            // btnVoltar
            // 
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Location = new Point(61, 409);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(158, 47);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
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
            // btnDados
            // 
            btnDados.BackColor = Color.FromArgb(253, 208, 23);
            btnDados.FlatStyle = FlatStyle.Popup;
            btnDados.ForeColor = Color.White;
            btnDados.Location = new Point(61, 356);
            btnDados.Name = "btnDados";
            btnDados.Size = new Size(158, 47);
            btnDados.TabIndex = 10;
            btnDados.Text = "Dados";
            btnDados.UseVisualStyleBackColor = false;
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
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1345, 694);
            Controls.Add(btnProduto);
            Controls.Add(btnDados);
            Controls.Add(btnPedido);
            Controls.Add(btnVoltar);
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
        private Button btnVoltar;
        private Button btnProduto;
        private Button btnDados;
        private Button btnPedido;
    }
}