namespace Projeto_Valquiria
{
    partial class FrmPedidos
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
            cmbClientes = new ComboBox();
            btnCadastroCliente = new Button();
            cmbProdutos = new ComboBox();
            lblValor = new Label();
            btnCadastrarPedido = new Button();
            btnProduto = new Button();
            a = new Label();
            panel1 = new Panel();
            lblTotal = new Label();
            lblContato = new Label();
            lblValorProduto = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbStatus = new ComboBox();
            label1 = new Label();
            txtQuantidade = new TextBox();
            dgvPedidos = new DataGridView();
            panel2 = new Panel();
            btnPedido = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(169, 16);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(334, 36);
            cmbClientes.TabIndex = 0;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged_1;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCadastroCliente.FlatStyle = FlatStyle.Flat;
            btnCadastroCliente.Location = new Point(59, 472);
            btnCadastroCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(181, 57);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(18, 63);
            cmbProdutos.Margin = new Padding(3, 4, 3, 4);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(201, 28);
            cmbProdutos.TabIndex = 2;
            cmbProdutos.Text = "Produtos";
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged_1;
            // 
            // lblValor
            // 
            lblValor.BackColor = Color.White;
            lblValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(18, 105);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(214, 36);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor total";
            // 
            // btnCadastrarPedido
            // 
            btnCadastrarPedido.BackColor = Color.White;
            btnCadastrarPedido.Location = new Point(517, 103);
            btnCadastrarPedido.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarPedido.Name = "btnCadastrarPedido";
            btnCadastrarPedido.Size = new Size(223, 36);
            btnCadastrarPedido.TabIndex = 9;
            btnCadastrarPedido.Text = "Cadastrar Pedido";
            btnCadastrarPedido.UseVisualStyleBackColor = false;
            btnCadastrarPedido.Click += btnCadastrarPedido_Click_1;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Location = new Point(59, 380);
            btnProduto.Margin = new Padding(3, 4, 3, 4);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(181, 63);
            btnProduto.TabIndex = 10;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            // 
            // a
            // 
            a.AutoEllipsis = true;
            a.BackColor = Color.White;
            a.BorderStyle = BorderStyle.FixedSingle;
            a.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a.Location = new Point(741, 36);
            a.Name = "a";
            a.Size = new Size(421, 61);
            a.TabIndex = 11;
            a.Text = "Área de Cadastro de Pedidos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblContato);
            panel1.Controls.Add(lblValorProduto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(cmbClientes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(cmbProdutos);
            panel1.Controls.Add(btnCadastrarPedido);
            panel1.Location = new Point(402, 760);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 149);
            panel1.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.DimGray;
            lblTotal.Location = new Point(139, 109);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 25);
            lblTotal.TabIndex = 13;
            // 
            // lblContato
            // 
            lblContato.BackColor = Color.Gainsboro;
            lblContato.Location = new Point(528, 16);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(505, 39);
            lblContato.TabIndex = 12;
            // 
            // lblValorProduto
            // 
            lblValorProduto.BackColor = Color.Gainsboro;
            lblValorProduto.Location = new Point(358, 67);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(90, 20);
            lblValorProduto.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 67);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 12;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 67);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 12;
            label2.Text = "Valor Produto";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(279, 105);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(169, 28);
            cmbStatus.TabIndex = 11;
            cmbStatus.Text = "Status";
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 21);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 10;
            label1.Text = "Nome Cliente:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(599, 63);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(161, 27);
            txtQuantidade.TabIndex = 0;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged_1;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(402, 115);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(1048, 613);
            dgvPedidos.TabIndex = 14;
 
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(159, 214, 242);
            panel2.Controls.Add(btnPedido);
            panel2.Controls.Add(btnCadastroCliente);
            panel2.Controls.Add(btnProduto);
            panel2.Location = new Point(-3, -13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 1245);
            panel2.TabIndex = 15;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Location = new Point(59, 297);
            btnPedido.Margin = new Padding(3, 4, 3, 4);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(181, 63);
            btnPedido.TabIndex = 11;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1503, 160);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 190, 249);
            ClientSize = new Size(1636, 925);
            Controls.Add(btnEditar);
            Controls.Add(dgvPedidos);
            Controls.Add(a);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidos_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbClientes;
        private Button btnCadastroCliente;
        private ComboBox cmbProdutos;
        private Label lblValor;
        private Button btnCadastrarPedido;
        private Button btnProduto;
        private Label a;
        private Panel panel1;
        private TextBox txtQuantidade;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private Label lblContato;
        private Label lblValorProduto;
        private Label label3;
        private DataGridView dgvPedidos;
        private Panel panel2;
        private Button btnPedido;
        private Label lblTotal;
        private Button btnEditar;
    }
}