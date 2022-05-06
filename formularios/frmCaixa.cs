using gestaoDeClientesArtigosTheStore.DAL;
using gestaoDeClientesArtigosTheStore.Handlers;
using gestaoDeClientesArtigosTheStore.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmCaixa : Form
    {

        funcionarioDAL funcionarioDAL = new funcionarioDAL();
        artigoDAL artigoDAL = new artigoDAL();

        public frmCaixa()
        {
            InitializeComponent();

        }
        private void carregarListaFuncionario()
        {

            List<funcionario> funcionario = funcionarioDAL.listarFuncionarioActivos();

            comboBox_NumeroFuncionario.DataSource = funcionario;
            comboBox_NumeroFuncionario.DisplayMember = "nome";
            comboBox_NumeroFuncionario.ValueMember = "id";
        }



        private void carregarListaArtigos()
        {

            List<artigo> artigo = artigoDAL.listarArtigosActivos();

            comboBox_Descricao.DataSource = artigo;
            comboBox_Descricao.DisplayMember = "descricao";
            comboBox_Descricao.ValueMember = "id_artigo";
        }
        private void frmCaixa_Load(object sender, EventArgs e)
        {
            carregarListaFuncionario();
            carregarListaArtigos();
        }
    }
}
