namespace Projeto_Valquiria
{
    partial class Home
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
            pictureBox1 = new PictureBox();
            btnPedidos = new Button();
            btnDados = new Button();
            btnAlteracao = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnProdutos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 985);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(247, 157, 189);
            btnPedidos.Location = new Point(22, 28);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(228, 126);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += button1_Click;
            // 
            // btnDados
            // 
            btnDados.BackColor = Color.FromArgb(247, 157, 189);
            btnDados.Location = new Point(22, 419);
            btnDados.Name = "btnDados";
            btnDados.Size = new Size(228, 126);
            btnDados.TabIndex = 2;
            btnDados.Text = "Dados";
            btnDados.UseVisualStyleBackColor = false;
            btnDados.Click += button1_Click;
            // 
            // btnAlteracao
            // 
            btnAlteracao.BackColor = Color.FromArgb(247, 157, 189);
            btnAlteracao.Location = new Point(22, 614);
            btnAlteracao.Name = "btnAlteracao";
            btnAlteracao.Size = new Size(228, 126);
            btnAlteracao.TabIndex = 3;
            btnAlteracao.Text = "Alteração";
            btnAlteracao.UseVisualStyleBackColor = false;
            btnAlteracao.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(855, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(523, 23);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(782, 92);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 4;
            label2.Text = "Pesquisar:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(217, 217, 217);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(551, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1104, 717);
            dataGridView1.TabIndex = 5;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(247, 157, 189);
            btnProdutos.Location = new Point(22, 213);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(228, 126);
            btnProdutos.TabIndex = 7;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += button1_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 174, 250);
            ClientSize = new Size(1424, 985);
            Controls.Add(btnProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btnAlteracao);
            Controls.Add(btnDados);
            Controls.Add(btnPedidos);
            Controls.Add(pictureBox1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPedidos;
        private Button btnDados;
        private Button btnAlteracao;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnProdutos;
    }
}