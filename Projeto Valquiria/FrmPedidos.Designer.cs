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
            cbxClientes = new ComboBox();
            btnCadastroCliente = new Button();
            comboBox1 = new ComboBox();
            lblValor = new Label();
            btnCadastrarPedido = new Button();
            btnProduto = new Button();
            a = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            cmbStatus = new ComboBox();
            label2 = new Label();
            lblValorProduto = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnPedido = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbxClientes
            // 
            cbxClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxClientes.FormattingEnabled = true;
            cbxClientes.Location = new Point(148, 12);
            cbxClientes.Name = "cbxClientes";
            cbxClientes.Size = new Size(293, 29);
            cbxClientes.TabIndex = 0;
            cbxClientes.SelectedIndexChanged += cbxClientes_SelectedIndexChanged;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCadastroCliente.FlatStyle = FlatStyle.Flat;
            btnCadastroCliente.Location = new Point(52, 354);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(158, 43);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Produtos";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblValor
            // 
            lblValor.BackColor = Color.White;
            lblValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(16, 79);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(187, 27);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor total";
            // 
            // btnCadastrarPedido
            // 
            btnCadastrarPedido.BackColor = Color.White;
            btnCadastrarPedido.Location = new Point(452, 77);
            btnCadastrarPedido.Name = "btnCadastrarPedido";
            btnCadastrarPedido.Size = new Size(195, 27);
            btnCadastrarPedido.TabIndex = 9;
            btnCadastrarPedido.Text = "Cadastrar Pedido";
            btnCadastrarPedido.UseVisualStyleBackColor = false;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Location = new Point(52, 285);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(158, 47);
            btnProduto.TabIndex = 10;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnVoltar_Click;
            // 
            // a
            // 
            a.AutoEllipsis = true;
            a.BackColor = Color.White;
            a.BorderStyle = BorderStyle.FixedSingle;
            a.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a.Location = new Point(648, 27);
            a.Name = "a";
            a.Size = new Size(369, 46);
            a.TabIndex = 11;
            a.Text = "Área de Cadastro de Pedidos";
            a.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblValorProduto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(cbxClientes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnCadastrarPedido);
            panel1.Location = new Point(352, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 112);
            panel1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(524, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 10;
            label1.Text = "Nome Cliente:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(244, 79);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(148, 23);
            cmbStatus.TabIndex = 11;
            cmbStatus.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 50);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 12;
            label2.Text = "Valor Produto";
            // 
            // lblValorProduto
            // 
            lblValorProduto.BackColor = Color.Gainsboro;
            lblValorProduto.Location = new Point(313, 50);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(79, 15);
            lblValorProduto.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 50);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 12;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.BackColor = Color.Gainsboro;
            label4.Location = new Point(462, 12);
            label4.Name = "label4";
            label4.Size = new Size(442, 29);
            label4.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(917, 460);
            dataGridView1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(159, 214, 242);
            panel2.Controls.Add(btnPedido);
            panel2.Controls.Add(btnCadastroCliente);
            panel2.Controls.Add(btnProduto);
            panel2.Location = new Point(-3, -10);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 934);
            panel2.TabIndex = 15;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Location = new Point(52, 223);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(158, 47);
            btnPedido.TabIndex = 11;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 190, 249);
            ClientSize = new Size(1345, 694);
            Controls.Add(dataGridView1);
            Controls.Add(a);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            WindowState = FormWindowState.Maximized;
            Load += Pedidos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxClientes;
        private Button btnCadastroCliente;
        private ComboBox comboBox1;
        private Label lblValor;
        private Button btnCadastrarPedido;
        private Button btnProduto;
        private Label a;
        private Panel panel1;
        private TextBox textBox2;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private Label label4;
        private Label lblValorProduto;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnPedido;
    }
}