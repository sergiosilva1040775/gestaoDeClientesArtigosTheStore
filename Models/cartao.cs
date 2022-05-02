using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace gestaoDeClientesArtigosTheStore.Models
{
    public class cartao
    {
        public int num_cartao { get; set; }

        public int pontos { get; set; }

        public int id_cliente { get; set; }


        public cartao(int _num_cartao, int _pontos, int _id_cliente)
        //ctor cria construtor prop cria propriedade
        {
            this.num_cartao = _num_cartao;
            this.pontos = _pontos;
            this.id_cliente = _id_cliente;
        }

        public cartao()
        {

        }

    }  
}
