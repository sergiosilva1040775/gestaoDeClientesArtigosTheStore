using System;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_gerirEspecialidades_Click(object sender, EventArgs e)
        {
            formularios.frmGestaoClientes frmGestaoClientes = new formularios.frmGestaoClientes();
            frmGestaoClientes.ShowDialog();
        }

        private void ToolStripMenuItem_gerirMedicos_Click(object sender, EventArgs e)
        {
            formularios.frmGestaoFuncionario frmGestaoFuncionario = new formularios.frmGestaoFuncionario();
            frmGestaoFuncionario.ShowDialog();
        }

        private void ToolStripMenuItem_gerirClientes_Click(object sender, EventArgs e)
        {
            formularios.frmGestaoArtigo frmGestaoArtigo = new formularios.frmGestaoArtigo();
            frmGestaoArtigo.ShowDialog();
        }

        private void cartãoDeClienteComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.frmCompras_LinhasCompras frmCompras_LinhasCompras = new formularios.frmCompras_LinhasCompras();
            frmCompras_LinhasCompras.ShowDialog();
        }

        private void button_Nova_Venda_Click(object sender, EventArgs e)
        {
            formularios.frmCaixa frmCaixa = new formularios.frmCaixa();
            frmCaixa.ShowDialog();
        }
    }
}
