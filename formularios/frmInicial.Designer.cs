namespace gestaoDeClientesArtigosTheStore
{
    partial class frmInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_gerirEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_gerirMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_gerirClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoDeClienteComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Nova_Venda = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_gerirEspecialidades,
            this.cartãoDeClienteComprasToolStripMenuItem});
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.especialidadesToolStripMenuItem.Text = "Clientes";
            // 
            // ToolStripMenuItem_gerirEspecialidades
            // 
            this.ToolStripMenuItem_gerirEspecialidades.Name = "ToolStripMenuItem_gerirEspecialidades";
            this.ToolStripMenuItem_gerirEspecialidades.Size = new System.Drawing.Size(218, 22);
            this.ToolStripMenuItem_gerirEspecialidades.Text = "Gerir";
            this.ToolStripMenuItem_gerirEspecialidades.Click += new System.EventHandler(this.ToolStripMenuItem_gerirEspecialidades_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_gerirMedicos});
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.médicosToolStripMenuItem.Text = "Funcionários";
            // 
            // ToolStripMenuItem_gerirMedicos
            // 
            this.ToolStripMenuItem_gerirMedicos.Name = "ToolStripMenuItem_gerirMedicos";
            this.ToolStripMenuItem_gerirMedicos.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_gerirMedicos.Text = "Gerir";
            this.ToolStripMenuItem_gerirMedicos.Click += new System.EventHandler(this.ToolStripMenuItem_gerirMedicos_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_gerirClientes});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.clientesToolStripMenuItem.Text = "Artigos";
            // 
            // ToolStripMenuItem_gerirClientes
            // 
            this.ToolStripMenuItem_gerirClientes.Name = "ToolStripMenuItem_gerirClientes";
            this.ToolStripMenuItem_gerirClientes.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_gerirClientes.Text = "Gerir";
            this.ToolStripMenuItem_gerirClientes.Click += new System.EventHandler(this.ToolStripMenuItem_gerirClientes_Click);
            // 
            // cartãoDeClienteComprasToolStripMenuItem
            // 
            this.cartãoDeClienteComprasToolStripMenuItem.Name = "cartãoDeClienteComprasToolStripMenuItem";
            this.cartãoDeClienteComprasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cartãoDeClienteComprasToolStripMenuItem.Text = "Cartão de Cliente/Compras";
            this.cartãoDeClienteComprasToolStripMenuItem.Click += new System.EventHandler(this.cartãoDeClienteComprasToolStripMenuItem_Click);
            // 
            // button_Nova_Venda
            // 
            this.button_Nova_Venda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nova_Venda.Location = new System.Drawing.Point(126, 52);
            this.button_Nova_Venda.Name = "button_Nova_Venda";
            this.button_Nova_Venda.Size = new System.Drawing.Size(180, 120);
            this.button_Nova_Venda.TabIndex = 1;
            this.button_Nova_Venda.Text = "Nova Venda";
            this.button_Nova_Venda.UseVisualStyleBackColor = true;
            this.button_Nova_Venda.Click += new System.EventHandler(this.button_Nova_Venda_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 215);
            this.Controls.Add(this.button_Nova_Venda);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aldi Style - Gestão De Clientes Artigos The Store";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_gerirEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_gerirMedicos;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_gerirClientes;
        private System.Windows.Forms.ToolStripMenuItem cartãoDeClienteComprasToolStripMenuItem;
        private System.Windows.Forms.Button button_Nova_Venda;
    }
}

