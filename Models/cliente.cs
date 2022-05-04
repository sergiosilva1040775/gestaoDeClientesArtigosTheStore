using System;

namespace gestaoDeClientesArtigosTheStore.Models
{
    public class cliente
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string morada { get; set; }

        public string telefone { get; set; }

        public string e_mail { get; set; }

        public string contribuinte { get; set; }

        public string localidade { get; set; }

        public int num_cartao { get; set; }

        public string fotografia { get; set; }

        public string pass { get; set; }



        public cliente(int _id, string _nome, string _morada, string _telefone, string _e_mail, string _contribuinte, string _localidade, int _num_cartao, string _fotografia, string _pass)
        //ctor cria construtor prop cria propriedade
        {
            this.id = _id;
            this.nome = _nome;
            this.morada = _morada;
            this.telefone = _telefone;
            this.e_mail = _e_mail;
            this.contribuinte = _contribuinte;
            this.localidade = _localidade;
            this.num_cartao = _num_cartao;
            this.fotografia = _fotografia;
            this.pass = _pass;
        }

        public cliente()
        {

        }

    }
}
