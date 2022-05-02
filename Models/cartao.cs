using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace gestaoDeClientesArtigosTheStore.Models
{
    public class cartao
    {

        public string numeroNIF { get; set; }

        public string nomeAplido { get; set; }

        public string contactoMovel { get; set; }

        public string numeroSNS { get; set; }



        public cartao(string numeroNIF, string nomeAplido,   string contactoMovel, string numeroSNS)
        //ctor cria construtor prop cria propriedade
        {

            this.numeroNIF = numeroNIF;
            this.nomeAplido = nomeAplido;
            this.contactoMovel = contactoMovel;
            this.numeroSNS = numeroSNS;



        }
        public cartao()
        {

        }

    }  
}
