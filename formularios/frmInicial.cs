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
            formularios.frmGestaoFuncionario frmGestaoFuncionario = new formularios.frmGestaoFuncionario();
            frmGestaoFuncionario.ShowDialog();
        }

        private void ToolStripMenuItem_gerirMedicos_Click(object sender, EventArgs e)
        {
            formularios.frmGestaoCliente frmGestaoFuncionario = new formularios.frmGestaoCliente();
            frmGestaoFuncionario.ShowDialog();
        }
    }
}
