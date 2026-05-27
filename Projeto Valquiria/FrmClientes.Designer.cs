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
            btnVoltar = new Button();
            lblNome = new Label();
            lblContato = new Label();
            pnlCadastro = new Panel();
            dvgTabela = new DataGridView();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
<<<<<<< HEAD
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(624, 55);
            label1.Name = "label1";
            label1.Size = new Size(413, 67);
            label1.TabIndex = 0;
            label1.Text = "Área de cadastro de pedidos";
=======
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 53);
            label1.Name = "label1";
            label1.Size = new Size(361, 38);
            label1.TabIndex = 0;
            label1.Text = "Área de cadastro de cliente";
            label1.Click += label1_Click;
>>>>>>> 0d523edf703c869ea4cad117b07e93ed3d3ef108
            // 
            // txtNome
            // 
<<<<<<< HEAD
            txtNome.Location = new Point(87, 15);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(755, 27);
            txtNome.TabIndex = 1;
=======
            txtNomeCliente.Location = new Point(76, 11);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Digite o Nome do Cliente";
            txtNomeCliente.Size = new Size(963, 23);
            txtNomeCliente.TabIndex = 1;
>>>>>>> 0d523edf703c869ea4cad117b07e93ed3d3ef108
            // 
            // txtContato
            // 
<<<<<<< HEAD
            txtContato.Location = new Point(87, 83);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(611, 27);
            txtContato.TabIndex = 1;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(721, 92);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
=======
            txtContatos.Location = new Point(76, 62);
            txtContatos.Name = "txtContatos";
            txtContatos.PlaceholderText = "Digite o Contato do Cliente";
            txtContatos.Size = new Size(843, 23);
            txtContatos.TabIndex = 1;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(925, 61);
>>>>>>> 0d523edf703c869ea4cad117b07e93ed3d3ef108
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(130, 31);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cadastrar Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(38, 28);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(154, 93);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.White;
            lblNome.Location = new Point(55, 715);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.White;
            lblContato.Location = new Point(43, 788);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(65, 20);
            lblContato.TabIndex = 5;
            lblContato.Text = "Contato:";
            // 
            // pnlCadastro
            // 
<<<<<<< HEAD
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(btnCliente);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Controls.Add(txtContato);
            pnlCadastro.Location = new Point(24, 696);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(869, 147);
            pnlCadastro.TabIndex = 6;
=======
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(txtNomeCliente);
            panel1.Controls.Add(txtContatos);
            panel1.Location = new Point(21, 522);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 110);
            panel1.TabIndex = 6;
>>>>>>> 0d523edf703c869ea4cad117b07e93ed3d3ef108
            // 
            // dvgTabela
            // 
            dvgTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTabela.Location = new Point(111, 169);
            dvgTabela.Margin = new Padding(3, 4, 3, 4);
            dvgTabela.Name = "dvgTabela";
            dvgTabela.RowHeadersWidth = 51;
            dvgTabela.Size = new Size(1414, 477);
            dvgTabela.TabIndex = 7;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1720, 1055);
            Controls.Add(dvgTabela);
            Controls.Add(lblContato);
            Controls.Add(lblNome);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(pnlCadastro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmClientes_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtContato;
        private Button btnCliente;
        private Button btnVoltar;
        private Label lblNome;
        private Label lblContato;
        private Panel pnlCadastro;
        private DataGridView dvgTabela;
    }
}