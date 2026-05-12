namespace Projeto_Valquiria
{
    partial class Dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dados));
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(217, 217, 217);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(405, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1104, 717);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(52, 174, 250);
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Location = new Point(1588, 191);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(52, 53);
            btnEditar.TabIndex = 1;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // Dados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 174, 250);
            ClientSize = new Size(1726, 1061);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            Name = "Dados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dados";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEditar;
    }
}