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
            cbxClientes.Location = new Point(753, 287);
            cbxClientes.Name = "cbxClientes";
            cbxClientes.Size = new Size(479, 29);
            cbxClientes.TabIndex = 0;
            cbxClientes.SelectedIndexChanged += cbxClientes_SelectedIndexChanged;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.Location = new Point(753, 332);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(479, 40);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cadastrar Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = true;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(753, 425);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Produtos";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtQuantidadePedido
            // 
            txtQuantidadePedido.Location = new Point(1148, 425);
            txtQuantidadePedido.Name = "txtQuantidadePedido";
            txtQuantidadePedido.Size = new Size(64, 23);
            txtQuantidadePedido.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1065, 428);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Quantidade:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(753, 478);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 35);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(753, 531);
            label2.Name = "label2";
            label2.Size = new Size(187, 27);
            label2.TabIndex = 6;
            label2.Text = "Valor total / Valor pago";
            // 
            // lblValores
            // 
            lblValores.BackColor = Color.White;
            lblValores.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValores.Location = new Point(1045, 478);
            lblValores.Name = "lblValores";
            lblValores.Size = new Size(187, 35);
            lblValores.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(951, 587);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 26);
            lblTotal.TabIndex = 8;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnCadastrarPedido
            // 
            btnCadastrarPedido.Location = new Point(836, 635);
            btnCadastrarPedido.Name = "btnCadastrarPedido";
            btnCadastrarPedido.Size = new Size(327, 44);
            btnCadastrarPedido.TabIndex = 9;
            btnCadastrarPedido.Text = "Cadastrar Pedido";
            btnCadastrarPedido.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(1395, 176);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(135, 70);
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
            a.Location = new Point(803, 210);
            a.Name = "a";
            a.Size = new Size(369, 46);
            a.TabIndex = 11;
            a.Text = "Área de Cadastro de Pedidos";
            a.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(984, 488);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 12;
            label3.Text = "=";
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 190, 249);
            ClientSize = new Size(1623, 791);
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
            Name = "FrmPedidos";
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