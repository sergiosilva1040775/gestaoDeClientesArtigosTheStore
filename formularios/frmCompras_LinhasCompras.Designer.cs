namespace gestaoDeClientesArtigosTheStore.formularios
{
    partial class frmCompras_LinhasCompras
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
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Pontos = new System.Windows.Forms.Label();
            this.dataGridView_ComprasEfectuadas = new System.Windows.Forms.DataGridView();
            this.label_ComprasEfectuadas = new System.Windows.Forms.Label();
            this.label_ProdutosComprados = new System.Windows.Forms.Label();
            this.dataGridView_ProdutosComprados = new System.Windows.Forms.DataGridView();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ComprasEfectuadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProdutosComprados)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(9, 31);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Cliente.TabIndex = 0;
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(12, 15);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(39, 13);
            this.label_Cliente.TabIndex = 2;
            this.label_Cliente.Text = "Cliente";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(9, 78);
            this.textBox_ID.MaxLength = 9;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(164, 20);
            this.textBox_ID.TabIndex = 7;
            // 
            // label_Pontos
            // 
            this.label_Pontos.AutoSize = true;
            this.label_Pontos.Location = new System.Drawing.Point(11, 62);
            this.label_Pontos.Name = "label_Pontos";
            this.label_Pontos.Size = new System.Drawing.Size(95, 13);
            this.label_Pontos.TabIndex = 6;
            this.label_Pontos.Text = "Número de Pontos";
            // 
            // dataGridView_ComprasEfectuadas
            // 
            this.dataGridView_ComprasEfectuadas.AllowUserToAddRows = false;
            this.dataGridView_ComprasEfectuadas.AllowUserToDeleteRows = false;
            this.dataGridView_ComprasEfectuadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ComprasEfectuadas.Location = new System.Drawing.Point(9, 120);
            this.dataGridView_ComprasEfectuadas.Name = "dataGridView_ComprasEfectuadas";
            this.dataGridView_ComprasEfectuadas.ReadOnly = true;
            this.dataGridView_ComprasEfectuadas.Size = new System.Drawing.Size(311, 154);
            this.dataGridView_ComprasEfectuadas.TabIndex = 8;
            // 
            // label_ComprasEfectuadas
            // 
            this.label_ComprasEfectuadas.AutoSize = true;
            this.label_ComprasEfectuadas.Location = new System.Drawing.Point(12, 104);
            this.label_ComprasEfectuadas.Name = "label_ComprasEfectuadas";
            this.label_ComprasEfectuadas.Size = new System.Drawing.Size(105, 13);
            this.label_ComprasEfectuadas.TabIndex = 9;
            this.label_ComprasEfectuadas.Text = "Compras Efectuadas";
            // 
            // label_ProdutosComprados
            // 
            this.label_ProdutosComprados.AutoSize = true;
            this.label_ProdutosComprados.Location = new System.Drawing.Point(12, 288);
            this.label_ProdutosComprados.Name = "label_ProdutosComprados";
            this.label_ProdutosComprados.Size = new System.Drawing.Size(105, 13);
            this.label_ProdutosComprados.TabIndex = 11;
            this.label_ProdutosComprados.Text = "Produtos Comprados";
            // 
            // dataGridView_ProdutosComprados
            // 
            this.dataGridView_ProdutosComprados.AllowUserToAddRows = false;
            this.dataGridView_ProdutosComprados.AllowUserToDeleteRows = false;
            this.dataGridView_ProdutosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProdutosComprados.Location = new System.Drawing.Point(9, 304);
            this.dataGridView_ProdutosComprados.Name = "dataGridView_ProdutosComprados";
            this.dataGridView_ProdutosComprados.ReadOnly = true;
            this.dataGridView_ProdutosComprados.Size = new System.Drawing.Size(311, 154);
            this.dataGridView_ProdutosComprados.TabIndex = 10;
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.Location = new System.Drawing.Point(155, 29);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(88, 23);
            this.button_Pesquisar.TabIndex = 23;
            this.button_Pesquisar.Text = "Pesquisar";
            this.button_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // frmCompras_LinhasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 470);
            this.Controls.Add(this.button_Pesquisar);
            this.Controls.Add(this.label_ProdutosComprados);
            this.Controls.Add(this.dataGridView_ProdutosComprados);
            this.Controls.Add(this.label_ComprasEfectuadas);
            this.Controls.Add(this.dataGridView_ComprasEfectuadas);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Pontos);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.comboBox_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCompras_LinhasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão do Cartão";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ComprasEfectuadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProdutosComprados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Pontos;
        private System.Windows.Forms.DataGridView dataGridView_ComprasEfectuadas;
        private System.Windows.Forms.Label label_ComprasEfectuadas;
        private System.Windows.Forms.Label label_ProdutosComprados;
        private System.Windows.Forms.DataGridView dataGridView_ProdutosComprados;
        private System.Windows.Forms.Button button_Pesquisar;
    }
}