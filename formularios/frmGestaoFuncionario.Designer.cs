namespace gestaoDeClientesArtigosTheStore.formularios
{
    partial class frmGestaoFuncionario
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
            this.button_LimparCampos = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Actualizar = new System.Windows.Forms.Button();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.dataGridView_Medicos = new System.Windows.Forms.DataGridView();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Contacto = new System.Windows.Forms.TextBox();
            this.label_Contacto = new System.Windows.Forms.Label();
            this.textBox_PalavraChave = new System.Windows.Forms.TextBox();
            this.label_PalavraChave = new System.Windows.Forms.Label();
            this.textBox_numFuncionario = new System.Windows.Forms.TextBox();
            this.label_numFuncionario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LimparCampos
            // 
            this.button_LimparCampos.Location = new System.Drawing.Point(349, 264);
            this.button_LimparCampos.Name = "button_LimparCampos";
            this.button_LimparCampos.Size = new System.Drawing.Size(88, 23);
            this.button_LimparCampos.TabIndex = 25;
            this.button_LimparCampos.Text = "Limpar Campos";
            this.button_LimparCampos.UseVisualStyleBackColor = true;
            this.button_LimparCampos.Click += new System.EventHandler(this.button_LimparCampos_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(349, 236);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(88, 23);
            this.button_Delete.TabIndex = 24;
            this.button_Delete.Text = "Apagar";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Actualizar
            // 
            this.button_Actualizar.Location = new System.Drawing.Point(349, 210);
            this.button_Actualizar.Name = "button_Actualizar";
            this.button_Actualizar.Size = new System.Drawing.Size(88, 23);
            this.button_Actualizar.TabIndex = 23;
            this.button_Actualizar.Text = "Actualizar";
            this.button_Actualizar.UseVisualStyleBackColor = true;
            this.button_Actualizar.Click += new System.EventHandler(this.button_Actualizar_Click);
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(349, 182);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(88, 23);
            this.button_Adicionar.TabIndex = 22;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // dataGridView_Medicos
            // 
            this.dataGridView_Medicos.AllowUserToAddRows = false;
            this.dataGridView_Medicos.AllowUserToDeleteRows = false;
            this.dataGridView_Medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Medicos.Location = new System.Drawing.Point(11, 15);
            this.dataGridView_Medicos.Name = "dataGridView_Medicos";
            this.dataGridView_Medicos.ReadOnly = true;
            this.dataGridView_Medicos.Size = new System.Drawing.Size(476, 154);
            this.dataGridView_Medicos.TabIndex = 13;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(131, 229);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(164, 20);
            this.textBox_Nome.TabIndex = 29;
            // 
            // textBox_Id
            // 
            this.textBox_Id.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Id.Location = new System.Drawing.Point(131, 182);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(164, 20);
            this.textBox_Id.TabIndex = 28;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(16, 229);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 27;
            this.label_Nome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Número Id";
            // 
            // textBox_Contacto
            // 
            this.textBox_Contacto.Location = new System.Drawing.Point(131, 255);
            this.textBox_Contacto.Name = "textBox_Contacto";
            this.textBox_Contacto.Size = new System.Drawing.Size(164, 20);
            this.textBox_Contacto.TabIndex = 31;
            // 
            // label_Contacto
            // 
            this.label_Contacto.AutoSize = true;
            this.label_Contacto.Location = new System.Drawing.Point(16, 255);
            this.label_Contacto.Name = "label_Contacto";
            this.label_Contacto.Size = new System.Drawing.Size(50, 13);
            this.label_Contacto.TabIndex = 30;
            this.label_Contacto.Text = "Contacto";
            // 
            // textBox_PalavraChave
            // 
            this.textBox_PalavraChave.Location = new System.Drawing.Point(131, 281);
            this.textBox_PalavraChave.Name = "textBox_PalavraChave";
            this.textBox_PalavraChave.PasswordChar = 'ª';
            this.textBox_PalavraChave.Size = new System.Drawing.Size(164, 20);
            this.textBox_PalavraChave.TabIndex = 43;
            // 
            // label_PalavraChave
            // 
            this.label_PalavraChave.AutoSize = true;
            this.label_PalavraChave.Location = new System.Drawing.Point(16, 282);
            this.label_PalavraChave.Name = "label_PalavraChave";
            this.label_PalavraChave.Size = new System.Drawing.Size(77, 13);
            this.label_PalavraChave.TabIndex = 42;
            this.label_PalavraChave.Text = "Palavra Chave";
            // 
            // textBox_numFuncionario
            // 
            this.textBox_numFuncionario.Location = new System.Drawing.Point(131, 206);
            this.textBox_numFuncionario.Name = "textBox_numFuncionario";
            this.textBox_numFuncionario.Size = new System.Drawing.Size(164, 20);
            this.textBox_numFuncionario.TabIndex = 45;
            // 
            // label_numFuncionario
            // 
            this.label_numFuncionario.AutoSize = true;
            this.label_numFuncionario.Location = new System.Drawing.Point(16, 207);
            this.label_numFuncionario.Name = "label_numFuncionario";
            this.label_numFuncionario.Size = new System.Drawing.Size(102, 13);
            this.label_numFuncionario.TabIndex = 44;
            this.label_numFuncionario.Text = "Número Funcionário";
            // 
            // frmGestaoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 319);
            this.Controls.Add(this.textBox_numFuncionario);
            this.Controls.Add(this.label_numFuncionario);
            this.Controls.Add(this.textBox_PalavraChave);
            this.Controls.Add(this.label_PalavraChave);
            this.Controls.Add(this.textBox_Contacto);
            this.Controls.Add(this.label_Contacto);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_LimparCampos);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Actualizar);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.dataGridView_Medicos);
            this.MaximizeBox = false;
            this.Name = "frmGestaoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGestaoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LimparCampos;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Actualizar;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.DataGridView dataGridView_Medicos;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Contacto;
        private System.Windows.Forms.Label label_Contacto;
        private System.Windows.Forms.TextBox textBox_PalavraChave;
        private System.Windows.Forms.Label label_PalavraChave;
        private System.Windows.Forms.TextBox textBox_numFuncionario;
        private System.Windows.Forms.Label label_numFuncionario;
    }
}