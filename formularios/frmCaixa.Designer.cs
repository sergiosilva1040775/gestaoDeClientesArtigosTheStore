namespace gestaoDeClientesArtigosTheStore.formularios
{
    partial class frmCaixa
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
            this.textBox_Contacto = new System.Windows.Forms.TextBox();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.label_Contacto = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_NumeroCartao = new System.Windows.Forms.Label();
            this.textBox_NumeroCartao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_numeroPontos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_NumFuncionario = new System.Windows.Forms.TextBox();
            this.comboBox_NumeroFuncionario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Id_Cliente = new System.Windows.Forms.TextBox();
            this.button_pesquisar_cliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ProdutosComprados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_lihaAdicionada = new System.Windows.Forms.TextBox();
            this.textBox_IdCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_precototalLinha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Preco = new System.Windows.Forms.TextBox();
            this.button_pesquisar_artigos = new System.Windows.Forms.Button();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.label_Quantidade = new System.Windows.Forms.Label();
            this.textBox_Quantidade = new System.Windows.Forms.TextBox();
            this.label_ArtigoId = new System.Windows.Forms.Label();
            this.comboBox_Descricao = new System.Windows.Forms.ComboBox();
            this.label_Descricao = new System.Windows.Forms.Label();
            this.textBox_ArtigoId = new System.Windows.Forms.TextBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox_ValotTotalCompra = new System.Windows.Forms.TextBox();
            this.button_FecharCompra = new System.Windows.Forms.Button();
            this.textBox_pontos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProdutosComprados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Contacto
            // 
            this.textBox_Contacto.Location = new System.Drawing.Point(108, 16);
            this.textBox_Contacto.MaxLength = 9999999;
            this.textBox_Contacto.Name = "textBox_Contacto";
            this.textBox_Contacto.Size = new System.Drawing.Size(200, 20);
            this.textBox_Contacto.TabIndex = 26;
            this.textBox_Contacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(108, 42);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Cliente.TabIndex = 17;
            this.comboBox_Cliente.SelectedValueChanged += new System.EventHandler(this.comboBox_Cliente_SelectedValueChanged);
            // 
            // label_Contacto
            // 
            this.label_Contacto.AutoSize = true;
            this.label_Contacto.Location = new System.Drawing.Point(56, 19);
            this.label_Contacto.Name = "label_Contacto";
            this.label_Contacto.Size = new System.Drawing.Size(50, 13);
            this.label_Contacto.TabIndex = 31;
            this.label_Contacto.Text = "Contacto";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(71, 46);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 32;
            this.label_Nome.Text = "Nome";
            // 
            // label_NumeroCartao
            // 
            this.label_NumeroCartao.AutoSize = true;
            this.label_NumeroCartao.Location = new System.Drawing.Point(28, 72);
            this.label_NumeroCartao.Name = "label_NumeroCartao";
            this.label_NumeroCartao.Size = new System.Drawing.Size(78, 13);
            this.label_NumeroCartao.TabIndex = 34;
            this.label_NumeroCartao.Text = "Número Cartão";
            // 
            // textBox_NumeroCartao
            // 
            this.textBox_NumeroCartao.Location = new System.Drawing.Point(108, 69);
            this.textBox_NumeroCartao.MaxLength = 2;
            this.textBox_NumeroCartao.Name = "textBox_NumeroCartao";
            this.textBox_NumeroCartao.ReadOnly = true;
            this.textBox_NumeroCartao.Size = new System.Drawing.Size(200, 20);
            this.textBox_NumeroCartao.TabIndex = 33;
            this.textBox_NumeroCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Pontos Acumulados";
            // 
            // textBox_numeroPontos
            // 
            this.textBox_numeroPontos.Location = new System.Drawing.Point(108, 95);
            this.textBox_numeroPontos.MaxLength = 2;
            this.textBox_numeroPontos.Name = "textBox_numeroPontos";
            this.textBox_numeroPontos.ReadOnly = true;
            this.textBox_numeroPontos.Size = new System.Drawing.Size(200, 20);
            this.textBox_numeroPontos.TabIndex = 35;
            this.textBox_numeroPontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Número Funcionário";
            // 
            // textBox_NumFuncionario
            // 
            this.textBox_NumFuncionario.Location = new System.Drawing.Point(109, 23);
            this.textBox_NumFuncionario.MaxLength = 9999999;
            this.textBox_NumFuncionario.Name = "textBox_NumFuncionario";
            this.textBox_NumFuncionario.ReadOnly = true;
            this.textBox_NumFuncionario.Size = new System.Drawing.Size(200, 20);
            this.textBox_NumFuncionario.TabIndex = 39;
            this.textBox_NumFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_NumeroFuncionario
            // 
            this.comboBox_NumeroFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NumeroFuncionario.FormattingEnabled = true;
            this.comboBox_NumeroFuncionario.Location = new System.Drawing.Point(109, 49);
            this.comboBox_NumeroFuncionario.Name = "comboBox_NumeroFuncionario";
            this.comboBox_NumeroFuncionario.Size = new System.Drawing.Size(200, 21);
            this.comboBox_NumeroFuncionario.TabIndex = 37;
            this.comboBox_NumeroFuncionario.SelectedValueChanged += new System.EventHandler(this.comboBox_NumeroFuncionario_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_NumeroFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_NumFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 88);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Id_Cliente);
            this.groupBox2.Controls.Add(this.button_pesquisar_cliente);
            this.groupBox2.Controls.Add(this.label_Contacto);
            this.groupBox2.Controls.Add(this.comboBox_Cliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Contacto);
            this.groupBox2.Controls.Add(this.textBox_numeroPontos);
            this.groupBox2.Controls.Add(this.label_Nome);
            this.groupBox2.Controls.Add(this.label_NumeroCartao);
            this.groupBox2.Controls.Add(this.textBox_NumeroCartao);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 127);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informção Cliente";
            // 
            // textBox_Id_Cliente
            // 
            this.textBox_Id_Cliente.Location = new System.Drawing.Point(336, 96);
            this.textBox_Id_Cliente.MaxLength = 2;
            this.textBox_Id_Cliente.Name = "textBox_Id_Cliente";
            this.textBox_Id_Cliente.ReadOnly = true;
            this.textBox_Id_Cliente.Size = new System.Drawing.Size(45, 20);
            this.textBox_Id_Cliente.TabIndex = 45;
            this.textBox_Id_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Id_Cliente.Visible = false;
            // 
            // button_pesquisar_cliente
            // 
            this.button_pesquisar_cliente.Location = new System.Drawing.Point(314, 19);
            this.button_pesquisar_cliente.Name = "button_pesquisar_cliente";
            this.button_pesquisar_cliente.Size = new System.Drawing.Size(82, 58);
            this.button_pesquisar_cliente.TabIndex = 44;
            this.button_pesquisar_cliente.Text = "Pesquisar";
            this.button_pesquisar_cliente.UseVisualStyleBackColor = true;
            this.button_pesquisar_cliente.Click += new System.EventHandler(this.button_pesquisar_cliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_ProdutosComprados);
            this.groupBox3.Location = new System.Drawing.Point(440, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 312);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de produtos";
            // 
            // dataGridView_ProdutosComprados
            // 
            this.dataGridView_ProdutosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProdutosComprados.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_ProdutosComprados.Name = "dataGridView_ProdutosComprados";
            this.dataGridView_ProdutosComprados.Size = new System.Drawing.Size(352, 287);
            this.dataGridView_ProdutosComprados.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_lihaAdicionada);
            this.groupBox4.Controls.Add(this.textBox_IdCompra);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox_precototalLinha);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox_Preco);
            this.groupBox4.Controls.Add(this.button_pesquisar_artigos);
            this.groupBox4.Controls.Add(this.button_Adicionar);
            this.groupBox4.Controls.Add(this.label_Quantidade);
            this.groupBox4.Controls.Add(this.textBox_Quantidade);
            this.groupBox4.Controls.Add(this.label_ArtigoId);
            this.groupBox4.Controls.Add(this.comboBox_Descricao);
            this.groupBox4.Controls.Add(this.label_Descricao);
            this.groupBox4.Controls.Add(this.textBox_ArtigoId);
            this.groupBox4.Location = new System.Drawing.Point(12, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 217);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Artigos";
            // 
            // textBox_lihaAdicionada
            // 
            this.textBox_lihaAdicionada.Location = new System.Drawing.Point(345, 83);
            this.textBox_lihaAdicionada.MaxLength = 2;
            this.textBox_lihaAdicionada.Name = "textBox_lihaAdicionada";
            this.textBox_lihaAdicionada.ReadOnly = true;
            this.textBox_lihaAdicionada.Size = new System.Drawing.Size(51, 20);
            this.textBox_lihaAdicionada.TabIndex = 50;
            this.textBox_lihaAdicionada.Text = "0";
            this.textBox_lihaAdicionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_lihaAdicionada.Visible = false;
            // 
            // textBox_IdCompra
            // 
            this.textBox_IdCompra.Location = new System.Drawing.Point(345, 109);
            this.textBox_IdCompra.MaxLength = 2;
            this.textBox_IdCompra.Name = "textBox_IdCompra";
            this.textBox_IdCompra.ReadOnly = true;
            this.textBox_IdCompra.Size = new System.Drawing.Size(51, 20);
            this.textBox_IdCompra.TabIndex = 48;
            this.textBox_IdCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_IdCompra.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Preço";
            // 
            // textBox_precototalLinha
            // 
            this.textBox_precototalLinha.Location = new System.Drawing.Point(96, 125);
            this.textBox_precototalLinha.MaxLength = 2;
            this.textBox_precototalLinha.Name = "textBox_precototalLinha";
            this.textBox_precototalLinha.ReadOnly = true;
            this.textBox_precototalLinha.Size = new System.Drawing.Size(200, 20);
            this.textBox_precototalLinha.TabIndex = 48;
            this.textBox_precototalLinha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Preço";
            // 
            // textBox_Preco
            // 
            this.textBox_Preco.Location = new System.Drawing.Point(96, 73);
            this.textBox_Preco.MaxLength = 2;
            this.textBox_Preco.Name = "textBox_Preco";
            this.textBox_Preco.ReadOnly = true;
            this.textBox_Preco.Size = new System.Drawing.Size(200, 20);
            this.textBox_Preco.TabIndex = 46;
            this.textBox_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_pesquisar_artigos
            // 
            this.button_pesquisar_artigos.Location = new System.Drawing.Point(314, 19);
            this.button_pesquisar_artigos.Name = "button_pesquisar_artigos";
            this.button_pesquisar_artigos.Size = new System.Drawing.Size(82, 58);
            this.button_pesquisar_artigos.TabIndex = 45;
            this.button_pesquisar_artigos.Text = "Pesquisar";
            this.button_pesquisar_artigos.UseVisualStyleBackColor = true;
            this.button_pesquisar_artigos.Click += new System.EventHandler(this.button_pesquisar_artigos_Click);
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(314, 148);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(82, 58);
            this.button_Adicionar.TabIndex = 43;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // label_Quantidade
            // 
            this.label_Quantidade.AutoSize = true;
            this.label_Quantidade.Location = new System.Drawing.Point(32, 102);
            this.label_Quantidade.Name = "label_Quantidade";
            this.label_Quantidade.Size = new System.Drawing.Size(62, 13);
            this.label_Quantidade.TabIndex = 42;
            this.label_Quantidade.Text = "Quantidade";
            // 
            // textBox_Quantidade
            // 
            this.textBox_Quantidade.Location = new System.Drawing.Point(96, 99);
            this.textBox_Quantidade.MaxLength = 9999999;
            this.textBox_Quantidade.Name = "textBox_Quantidade";
            this.textBox_Quantidade.Size = new System.Drawing.Size(200, 20);
            this.textBox_Quantidade.TabIndex = 41;
            this.textBox_Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Quantidade.TextChanged += new System.EventHandler(this.textBox_Quantidade_TextChanged);
            // 
            // label_ArtigoId
            // 
            this.label_ArtigoId.AutoSize = true;
            this.label_ArtigoId.Location = new System.Drawing.Point(49, 23);
            this.label_ArtigoId.Name = "label_ArtigoId";
            this.label_ArtigoId.Size = new System.Drawing.Size(40, 13);
            this.label_ArtigoId.TabIndex = 39;
            this.label_ArtigoId.Text = "Código";
            // 
            // comboBox_Descricao
            // 
            this.comboBox_Descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Descricao.FormattingEnabled = true;
            this.comboBox_Descricao.Location = new System.Drawing.Point(96, 46);
            this.comboBox_Descricao.Name = "comboBox_Descricao";
            this.comboBox_Descricao.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Descricao.TabIndex = 37;
            this.comboBox_Descricao.SelectedIndexChanged += new System.EventHandler(this.comboBox_Descricao_SelectedIndexChanged);
            this.comboBox_Descricao.SelectedValueChanged += new System.EventHandler(this.comboBox_Descricao_SelectedValueChanged);
            // 
            // label_Descricao
            // 
            this.label_Descricao.AutoSize = true;
            this.label_Descricao.Location = new System.Drawing.Point(59, 50);
            this.label_Descricao.Name = "label_Descricao";
            this.label_Descricao.Size = new System.Drawing.Size(35, 13);
            this.label_Descricao.TabIndex = 40;
            this.label_Descricao.Text = "Nome";
            // 
            // textBox_ArtigoId
            // 
            this.textBox_ArtigoId.Location = new System.Drawing.Point(96, 20);
            this.textBox_ArtigoId.MaxLength = 9999999;
            this.textBox_ArtigoId.Name = "textBox_ArtigoId";
            this.textBox_ArtigoId.Size = new System.Drawing.Size(200, 20);
            this.textBox_ArtigoId.TabIndex = 38;
            this.textBox_ArtigoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(564, 337);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(31, 13);
            this.label_Total.TabIndex = 47;
            this.label_Total.Text = "Total";
            // 
            // textBox_ValotTotalCompra
            // 
            this.textBox_ValotTotalCompra.Location = new System.Drawing.Point(598, 333);
            this.textBox_ValotTotalCompra.MaxLength = 9999999;
            this.textBox_ValotTotalCompra.Name = "textBox_ValotTotalCompra";
            this.textBox_ValotTotalCompra.Size = new System.Drawing.Size(200, 20);
            this.textBox_ValotTotalCompra.TabIndex = 46;
            this.textBox_ValotTotalCompra.Text = "0";
            this.textBox_ValotTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_FecharCompra
            // 
            this.button_FecharCompra.Location = new System.Drawing.Point(715, 359);
            this.button_FecharCompra.Name = "button_FecharCompra";
            this.button_FecharCompra.Size = new System.Drawing.Size(82, 58);
            this.button_FecharCompra.TabIndex = 44;
            this.button_FecharCompra.Text = "Fechar Compra";
            this.button_FecharCompra.UseVisualStyleBackColor = true;
            this.button_FecharCompra.Click += new System.EventHandler(this.button_FecharCompra_Click);
            // 
            // textBox_pontos
            // 
            this.textBox_pontos.Location = new System.Drawing.Point(556, 383);
            this.textBox_pontos.MaxLength = 2;
            this.textBox_pontos.Name = "textBox_pontos";
            this.textBox_pontos.ReadOnly = true;
            this.textBox_pontos.Size = new System.Drawing.Size(153, 20);
            this.textBox_pontos.TabIndex = 51;
            this.textBox_pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Total Pontos Arrecadados";
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_pontos);
            this.Controls.Add(this.button_FecharCompra);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.textBox_ValotTotalCompra);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProdutosComprados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Contacto;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.Label label_Contacto;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_NumeroCartao;
        private System.Windows.Forms.TextBox textBox_NumeroCartao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_numeroPontos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_NumFuncionario;
        private System.Windows.Forms.ComboBox comboBox_NumeroFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_ArtigoId;
        private System.Windows.Forms.ComboBox comboBox_Descricao;
        private System.Windows.Forms.Label label_Descricao;
        private System.Windows.Forms.TextBox textBox_ArtigoId;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.Label label_Quantidade;
        private System.Windows.Forms.TextBox textBox_Quantidade;
        private System.Windows.Forms.DataGridView dataGridView_ProdutosComprados;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox textBox_ValotTotalCompra;
        private System.Windows.Forms.Button button_FecharCompra;
        private System.Windows.Forms.Button button_pesquisar_cliente;
        private System.Windows.Forms.Button button_pesquisar_artigos;
        private System.Windows.Forms.TextBox textBox_Id_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Preco;
        private System.Windows.Forms.TextBox textBox_IdCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_precototalLinha;
        private System.Windows.Forms.TextBox textBox_lihaAdicionada;
        private System.Windows.Forms.TextBox textBox_pontos;
        private System.Windows.Forms.Label label4;
    }
}