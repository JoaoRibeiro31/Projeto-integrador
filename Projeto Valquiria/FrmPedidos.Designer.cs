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
            txtQuantidadePedido = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            lblValores = new Label();
            lblTotal = new Label();
            btnCadastrarPedido = new Button();
            btnVoltar = new Button();
            a = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cbxClientes
            // 
            cbxClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxClientes.FormattingEnabled = true;
            cbxClientes.Location = new Point(861, 383);
            cbxClientes.Margin = new Padding(3, 4, 3, 4);
            cbxClientes.Name = "cbxClientes";
            cbxClientes.Size = new Size(547, 36);
            cbxClientes.TabIndex = 0;
            cbxClientes.Text = "Clientes";
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.Location = new Point(861, 443);
            btnCadastroCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(547, 53);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cadastrar Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = true;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(861, 567);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Produtos";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtQuantidadePedido
            // 
            txtQuantidadePedido.Location = new Point(1312, 567);
            txtQuantidadePedido.Margin = new Padding(3, 4, 3, 4);
            txtQuantidadePedido.Name = "txtQuantidadePedido";
            txtQuantidadePedido.Size = new Size(73, 27);
            txtQuantidadePedido.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1217, 571);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 4;
            label1.Text = "Quantidade:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(861, 637);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 42);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(861, 708);
            label2.Name = "label2";
            label2.Size = new Size(214, 36);
            label2.TabIndex = 6;
            label2.Text = "Valor total / Valor pago";
            // 
            // lblValores
            // 
            lblValores.BackColor = Color.White;
            lblValores.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValores.Location = new Point(1194, 637);
            lblValores.Name = "lblValores";
            lblValores.Size = new Size(214, 47);
            lblValores.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(1087, 783);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(105, 35);
            lblTotal.TabIndex = 8;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnCadastrarPedido
            // 
            btnCadastrarPedido.Location = new Point(955, 847);
            btnCadastrarPedido.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarPedido.Name = "btnCadastrarPedido";
            btnCadastrarPedido.Size = new Size(374, 59);
            btnCadastrarPedido.TabIndex = 9;
            btnCadastrarPedido.Text = "Cadastrar Pedido";
            btnCadastrarPedido.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(1594, 235);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(154, 93);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // a
            // 
            a.AutoEllipsis = true;
            a.BackColor = Color.White;
            a.BorderStyle = BorderStyle.FixedSingle;
            a.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a.Location = new Point(861, 267);
            a.Name = "a";
            a.Size = new Size(547, 61);
            a.TabIndex = 11;
            a.Text = "Área de Cadastro de Pedidos";
            a.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1125, 651);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 12;
            label3.Text = "=";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 174, 250);
            ClientSize = new Size(1855, 1055);
            Controls.Add(label3);
            Controls.Add(a);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrarPedido);
            Controls.Add(lblTotal);
            Controls.Add(lblValores);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtQuantidadePedido);
            Controls.Add(comboBox1);
            Controls.Add(btnCadastroCliente);
            Controls.Add(cbxClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            WindowState = FormWindowState.Maximized;
            Load += Pedidos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxClientes;
        private Button btnCadastroCliente;
        private ComboBox comboBox1;
        private TextBox txtQuantidadePedido;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label lblValores;
        private Label lblTotal;
        private Button btnCadastrarPedido;
        private Button btnVoltar;
        private Label a;
        private Label label3;
    }
}