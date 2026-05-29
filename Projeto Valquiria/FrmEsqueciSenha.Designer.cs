namespace Projeto_Valquiria
{
    partial class FrmEsqueciSenha
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
            panel1 = new Panel();
            btnFechar = new Button();
            btnAtualizarSenha = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtLogin = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnAtualizarSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(42, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 245);
            panel1.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(423, 25);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(54, 25);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnAtualizarSenha
            // 
            btnAtualizarSenha.Location = new Point(158, 170);
            btnAtualizarSenha.Name = "btnAtualizarSenha";
            btnAtualizarSenha.Size = new Size(169, 42);
            btnAtualizarSenha.TabIndex = 3;
            btnAtualizarSenha.Text = "Atualizar Senha";
            btnAtualizarSenha.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 110);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Nova Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 30);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "CPF:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 107);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite uma Senha de até 10 digitos";
            textBox2.Size = new Size(287, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 27);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "123.456.789-09";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(108, 68);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite um novo nome de Login";
            txtLogin.Size = new Size(287, 23);
            txtLogin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 71);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Login:";
            // 
            // FrmEsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 333);
            Controls.Add(panel1);
            Name = "FrmEsqueciSenha";
            Text = "FrmEsqueciSenha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button btnFechar;
        private Button btnAtualizarSenha;
        private TextBox txtLogin;
        private Label label3;
    }
}