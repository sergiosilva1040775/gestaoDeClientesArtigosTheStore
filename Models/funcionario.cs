using System;

namespace foiPicadaDeEnfermeiro.Models
{
    public class funcionario
    {

        public int id_artigo { get; }        

        public string descricao { get; }

        public string numeroIdPaciente { get; }

        public string nomeMedico { get; }

        public string nomeCliente { get; }




        public funcionario(int _id_artigo,  string _descricao, string numeroIdPaciente, string nomeMedico, string nomeCliente)
        //ctor cria construtor prop cria propriedade
        {

            this.id_artigo = _id_artigo;
            this.descricao = _descricao;
            this.numeroIdMedico = numeroIdMedico;
            this.numeroIdPaciente = numeroIdPaciente;
            this.nomeMedico = nomeMedico;
            this.nomeCliente = nomeCliente;


        }
        public funcionario()
        {

        }

    }
}
