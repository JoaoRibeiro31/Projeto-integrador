namespace Projeto_Valquiria
{
    partial class FrmProdutos
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
            btnVoltar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtValor = new TextBox();
            label3 = new Label();
            txtQuantidade = new TextBox();
            btnCadastroProduto = new Button();
            panel1 = new Panel();
            dgvDadosProdutos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.AccessibleRole = AccessibleRole.Alert;
            btnVoltar.Location = new Point(12, 33);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(135, 70);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(155, 848);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do produto";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(306, 848);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(854, 25);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 881);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 1;
            label2.Text = "Valor do Produto";
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 10F);
            txtValor.Location = new Point(306, 879);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(854, 25);
            txtValor.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 910);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 1;
            label3.Text = "Quantidade Disponível";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Cursor = Cursors.IBeam;
            txtQuantidade.Location = new Point(306, 910);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(854, 23);
            txtQuantidade.TabIndex = 2;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Location = new Point(1043, 10);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(131, 42);
            btnCadastroProduto.TabIndex = 3;
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCadastroProduto);
            panel1.Location = new Point(123, 838);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 117);
            panel1.TabIndex = 4;
            // 
            // dgvDadosProdutos
            // 
            dgvDadosProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosProdutos.Location = new Point(138, 135);
            dgvDadosProdutos.Name = "dgvDadosProdutos";
            dgvDadosProdutos.Size = new Size(1159, 656);
            dgvDadosProdutos.TabIndex = 5;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 226, 176);
            ClientSize = new Size(1424, 985);
            Controls.Add(dgvDadosProdutos);
            Controls.Add(txtQuantidade);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(panel1);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            WindowState = FormWindowState.Maximized;
            Load += Pedidos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtQuantidade;
        private Button btnCadastroProduto;
        private Panel panel1;
        private DataGridView dgvDadosProdutos;
    }
}