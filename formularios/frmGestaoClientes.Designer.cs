namespace gestaoDeClientesArtigosTheStore.formularios
{
    partial class frmGestaoClientes
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
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Especialidades = new System.Windows.Forms.DataGridView();
            this.textBox_Morada = new System.Windows.Forms.TextBox();
            this.label_Morada = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Contacto = new System.Windows.Forms.TextBox();
            this.label_Contacto = new System.Windows.Forms.Label();
            this.textBox_Localidade = new System.Windows.Forms.TextBox();
            this.label_Localidade = new System.Windows.Forms.Label();
            this.textBox_Contribuite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_PalavraChave = new System.Windows.Forms.TextBox();
            this.label_PalavraChave = new System.Windows.Forms.Label();
            this.textBox_Foto = new System.Windows.Forms.TextBox();
            this.label_Fotografia = new System.Windows.Forms.Label();
            this.textBoxNumeroCliente = new System.Windows.Forms.TextBox();
            this.label_NumeroCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Especialidades)).BeginInit();
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
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(126, 210);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(164, 20);
            this.textBox_Nome.TabIndex = 19;
            // 
            // textBox_Id
            // 
            this.textBox_Id.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Id.Location = new System.Drawing.Point(126, 182);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(164, 20);
            this.textBox_Id.TabIndex = 18;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(11, 210);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 15;
            this.label_Nome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Número Id";
            // 
            // dataGridView_Especialidades
            // 
            this.dataGridView_Especialidades.AllowUserToAddRows = false;
            this.dataGridView_Especialidades.AllowUserToDeleteRows = false;
            this.dataGridView_Especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Especialidades.Location = new System.Drawing.Point(11, 15);
            this.dataGridView_Especialidades.Name = "dataGridView_Especialidades";
            this.dataGridView_Especialidades.ReadOnly = true;
            this.dataGridView_Especialidades.Size = new System.Drawing.Size(476, 154);
            this.dataGridView_Especialidades.TabIndex = 13;
            // 
            // textBox_Morada
            // 
            this.textBox_Morada.Location = new System.Drawing.Point(126, 236);
            this.textBox_Morada.Name = "textBox_Morada";
            this.textBox_Morada.Size = new System.Drawing.Size(164, 20);
            this.textBox_Morada.TabIndex = 27;
            // 
            // label_Morada
            // 
            this.label_Morada.AutoSize = true;
            this.label_Morada.Location = new System.Drawing.Point(11, 236);
            this.label_Morada.Name = "label_Morada";
            this.label_Morada.Size = new System.Drawing.Size(43, 13);
            this.label_Morada.TabIndex = 26;
            this.label_Morada.Text = "Morada";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(126, 289);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(164, 20);
            this.textBox_Email.TabIndex = 31;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(11, 289);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(93, 13);
            this.label_Email.TabIndex = 30;
            this.label_Email.Text = "Correio Electónico";
            // 
            // textBox_Contacto
            // 
            this.textBox_Contacto.Location = new System.Drawing.Point(126, 263);
            this.textBox_Contacto.Name = "textBox_Contacto";
            this.textBox_Contacto.Size = new System.Drawing.Size(164, 20);
            this.textBox_Contacto.TabIndex = 29;
            // 
            // label_Contacto
            // 
            this.label_Contacto.AutoSize = true;
            this.label_Contacto.Location = new System.Drawing.Point(11, 263);
            this.label_Contacto.Name = "label_Contacto";
            this.label_Contacto.Size = new System.Drawing.Size(50, 13);
            this.label_Contacto.TabIndex = 28;
            this.label_Contacto.Text = "Contacto";
            // 
            // textBox_Localidade
            // 
            this.textBox_Localidade.Location = new System.Drawing.Point(126, 341);
            this.textBox_Localidade.Name = "textBox_Localidade";
            this.textBox_Localidade.Size = new System.Drawing.Size(164, 20);
            this.textBox_Localidade.TabIndex = 35;
            // 
            // label_Localidade
            // 
            this.label_Localidade.AutoSize = true;
            this.label_Localidade.Location = new System.Drawing.Point(11, 341);
            this.label_Localidade.Name = "label_Localidade";
            this.label_Localidade.Size = new System.Drawing.Size(59, 13);
            this.label_Localidade.TabIndex = 34;
            this.label_Localidade.Text = "Localidade";
            // 
            // textBox_Contribuite
            // 
            this.textBox_Contribuite.Location = new System.Drawing.Point(126, 315);
            this.textBox_Contribuite.Name = "textBox_Contribuite";
            this.textBox_Contribuite.Size = new System.Drawing.Size(164, 20);
            this.textBox_Contribuite.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Número  de Contribuinte";
            // 
            // textBox_PalavraChave
            // 
            this.textBox_PalavraChave.Location = new System.Drawing.Point(126, 420);
            this.textBox_PalavraChave.Name = "textBox_PalavraChave";
            this.textBox_PalavraChave.PasswordChar = 'ª';
            this.textBox_PalavraChave.Size = new System.Drawing.Size(164, 20);
            this.textBox_PalavraChave.TabIndex = 41;
            // 
            // label_PalavraChave
            // 
            this.label_PalavraChave.AutoSize = true;
            this.label_PalavraChave.Location = new System.Drawing.Point(11, 421);
            this.label_PalavraChave.Name = "label_PalavraChave";
            this.label_PalavraChave.Size = new System.Drawing.Size(77, 13);
            this.label_PalavraChave.TabIndex = 40;
            this.label_PalavraChave.Text = "Palavra Chave";
            // 
            // textBox_Foto
            // 
            this.textBox_Foto.Location = new System.Drawing.Point(126, 394);
            this.textBox_Foto.Name = "textBox_Foto";
            this.textBox_Foto.Size = new System.Drawing.Size(164, 20);
            this.textBox_Foto.TabIndex = 39;
            // 
            // label_Fotografia
            // 
            this.label_Fotografia.AutoSize = true;
            this.label_Fotografia.Location = new System.Drawing.Point(11, 395);
            this.label_Fotografia.Name = "label_Fotografia";
            this.label_Fotografia.Size = new System.Drawing.Size(54, 13);
            this.label_Fotografia.TabIndex = 38;
            this.label_Fotografia.Text = "Fotografia";
            // 
            // textBoxNumeroCliente
            // 
            this.textBoxNumeroCliente.Location = new System.Drawing.Point(126, 368);
            this.textBoxNumeroCliente.Name = "textBoxNumeroCliente";
            this.textBoxNumeroCliente.Size = new System.Drawing.Size(164, 20);
            this.textBoxNumeroCliente.TabIndex = 37;
            // 
            // label_NumeroCliente
            // 
            this.label_NumeroCliente.AutoSize = true;
            this.label_NumeroCliente.Location = new System.Drawing.Point(11, 368);
            this.label_NumeroCliente.Name = "label_NumeroCliente";
            this.label_NumeroCliente.Size = new System.Drawing.Size(97, 13);
            this.label_NumeroCliente.TabIndex = 36;
            this.label_NumeroCliente.Text = "Número  de Cliente";
            // 
            // frmGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 457);
            this.Controls.Add(this.textBox_PalavraChave);
            this.Controls.Add(this.label_PalavraChave);
            this.Controls.Add(this.textBox_Foto);
            this.Controls.Add(this.label_Fotografia);
            this.Controls.Add(this.textBoxNumeroCliente);
            this.Controls.Add(this.label_NumeroCliente);
            this.Controls.Add(this.textBox_Localidade);
            this.Controls.Add(this.label_Localidade);
            this.Controls.Add(this.textBox_Contribuite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textBox_Contacto);
            this.Controls.Add(this.label_Contacto);
            this.Controls.Add(this.textBox_Morada);
            this.Controls.Add(this.label_Morada);
            this.Controls.Add(this.button_LimparCampos);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Actualizar);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Especialidades);
            this.MaximizeBox = false;
            this.Name = "frmGestaoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGestaoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Especialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LimparCampos;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Actualizar;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Especialidades;
        private System.Windows.Forms.TextBox textBox_Morada;
        private System.Windows.Forms.Label label_Morada;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Contacto;
        private System.Windows.Forms.Label label_Contacto;
        private System.Windows.Forms.TextBox textBox_Localidade;
        private System.Windows.Forms.Label label_Localidade;
        private System.Windows.Forms.TextBox textBox_Contribuite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_PalavraChave;
        private System.Windows.Forms.Label label_PalavraChave;
        private System.Windows.Forms.TextBox textBox_Foto;
        private System.Windows.Forms.Label label_Fotografia;
        private System.Windows.Forms.TextBox textBoxNumeroCliente;
        private System.Windows.Forms.Label label_NumeroCliente;
    }
}