namespace gestaoDeClientesArtigosTheStore.formularios
{
    partial class frmGestaoArtigo
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
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_descricao = new System.Windows.Forms.Label();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_Valor_Unitario = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.textBox_Valor_Unitario = new System.Windows.Forms.TextBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.button_Actualizar = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_LimparCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.AllowUserToAddRows = false;
            this.dataGridView_Clientes.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.ReadOnly = true;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(476, 154);
            this.dataGridView_Clientes.TabIndex = 0;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(12, 179);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(56, 13);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "Número Id";
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Location = new System.Drawing.Point(12, 207);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(55, 13);
            this.label_descricao.TabIndex = 2;
            this.label_descricao.Text = "Descrição";
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.Location = new System.Drawing.Point(12, 266);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(68, 13);
            this.label_Stock.TabIndex = 4;
            this.label_Stock.Text = "Stock Actual";
            // 
            // label_Valor_Unitario
            // 
            this.label_Valor_Unitario.AutoSize = true;
            this.label_Valor_Unitario.Location = new System.Drawing.Point(12, 238);
            this.label_Valor_Unitario.Name = "label_Valor_Unitario";
            this.label_Valor_Unitario.Size = new System.Drawing.Size(70, 13);
            this.label_Valor_Unitario.TabIndex = 3;
            this.label_Valor_Unitario.Text = "Valor Unitário";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(93, 179);
            this.textBox_ID.MaxLength = 9;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(164, 20);
            this.textBox_ID.TabIndex = 5;
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Location = new System.Drawing.Point(93, 207);
            this.textBox_descricao.MaxLength = 12;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(164, 20);
            this.textBox_descricao.TabIndex = 6;
            // 
            // textBox_Valor_Unitario
            // 
            this.textBox_Valor_Unitario.Location = new System.Drawing.Point(91, 238);
            this.textBox_Valor_Unitario.Name = "textBox_Valor_Unitario";
            this.textBox_Valor_Unitario.Size = new System.Drawing.Size(164, 20);
            this.textBox_Valor_Unitario.TabIndex = 7;
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(91, 266);
            this.textBox_Stock.MaxLength = 9;
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(164, 20);
            this.textBox_Stock.TabIndex = 8;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(350, 179);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(88, 23);
            this.button_Adicionar.TabIndex = 9;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // button_Actualizar
            // 
            this.button_Actualizar.Location = new System.Drawing.Point(350, 207);
            this.button_Actualizar.Name = "button_Actualizar";
            this.button_Actualizar.Size = new System.Drawing.Size(88, 23);
            this.button_Actualizar.TabIndex = 10;
            this.button_Actualizar.Text = "Actualizar";
            this.button_Actualizar.UseVisualStyleBackColor = true;
            this.button_Actualizar.Click += new System.EventHandler(this.button_Actualizar_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(350, 233);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(88, 23);
            this.button_Delete.TabIndex = 11;
            this.button_Delete.Text = "Apagar";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_LimparCampos
            // 
            this.button_LimparCampos.Location = new System.Drawing.Point(350, 261);
            this.button_LimparCampos.Name = "button_LimparCampos";
            this.button_LimparCampos.Size = new System.Drawing.Size(88, 23);
            this.button_LimparCampos.TabIndex = 12;
            this.button_LimparCampos.Text = "Limpar Campos";
            this.button_LimparCampos.UseVisualStyleBackColor = true;
            this.button_LimparCampos.Click += new System.EventHandler(this.button_LimparCampos_Click);
            // 
            // frmGestaoArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 304);
            this.Controls.Add(this.button_LimparCampos);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Actualizar);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_Valor_Unitario);
            this.Controls.Add(this.textBox_descricao);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.label_Valor_Unitario);
            this.Controls.Add(this.label_descricao);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.dataGridView_Clientes);
            this.MaximizeBox = false;
            this.Name = "frmGestaoArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Artigos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGestaoArtigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_descricao;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.Label label_Valor_Unitario;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.TextBox textBox_Valor_Unitario;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.Button button_Actualizar;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_LimparCampos;
    }
}