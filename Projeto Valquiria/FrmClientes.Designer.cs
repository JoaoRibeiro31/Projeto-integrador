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
            txtNomeCliente = new TextBox();
            txtContatos = new TextBox();
            btnCliente = new Button();
            btnVoltar = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 41);
            label1.Name = "label1";
            label1.Size = new Size(361, 50);
            label1.TabIndex = 0;
            label1.Text = "Área de cadastro de pedidos";
            label1.Click += label1_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(76, 11);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(661, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // txtContatos
            // 
            txtContatos.Location = new Point(76, 62);
            txtContatos.Name = "txtContatos";
            txtContatos.Size = new Size(535, 23);
            txtContatos.TabIndex = 1;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(631, 69);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(114, 23);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cadastrar Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(33, 21);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(135, 70);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(48, 536);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(38, 591);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Contato:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(txtNomeCliente);
            panel1.Controls.Add(txtContatos);
            panel1.Location = new Point(21, 522);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 110);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1237, 358);
            dataGridView1.TabIndex = 7;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1505, 985);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += Clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeCliente;
        private TextBox txtContatos;
        private Button btnCliente;
        private Button btnVoltar;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}