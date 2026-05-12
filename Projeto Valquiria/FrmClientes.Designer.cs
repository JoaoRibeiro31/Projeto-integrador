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
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(833, 122);
            label1.Name = "label1";
            label1.Size = new Size(361, 50);
            label1.TabIndex = 0;
            label1.Text = "Área de cadastro de pedidos";
            label1.Click += label1_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(793, 227);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(435, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // txtContatos
            // 
            txtContatos.Location = new Point(793, 278);
            txtContatos.Name = "txtContatos";
            txtContatos.Size = new Size(435, 23);
            txtContatos.TabIndex = 1;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(782, 368);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(198, 53);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cadastrar Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(1321, 112);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(135, 70);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1505, 985);
            Controls.Add(btnVoltar);
            Controls.Add(btnCliente);
            Controls.Add(txtContatos);
            Controls.Add(txtNomeCliente);
            Controls.Add(label1);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeCliente;
        private TextBox txtContatos;
        private Button btnCliente;
        private Button btnVoltar;
    }
}