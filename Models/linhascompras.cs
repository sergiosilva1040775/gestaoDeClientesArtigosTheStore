using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace gestaoDeClientesArtigosTheStore.Models
{
    public class linhascompras
    {
        public int id { get; set; }

        public int id_compra { get; set; }

        public float qdd { get; set; }

        public int artigo { get; set; }

        public float total { get; set; }
        
        public linhascompras(int _id, int _id_compra, float _qdd, int _artigo, float _total)
        //ctor cria construtor prop cria propriedade
        {
            this.id = _id;
            this.id_compra = _id_compra;
            this.qdd = _qdd;
            this.artigo = _artigo;
            this.total = _total;
        }
        public linhascompras()
        {

        }

    }  
}
