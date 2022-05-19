using System;

using System.Collections.Generic;
using System.Text;

namespace gestaoDeClientesArtigosTheStore.Models
{
    public class linhaCompra
    {
        public int id { get; set; }

        public string id_compra { get; set; }

        public double qdd { get; set; }

        public int artigo { get; set; }

        public string descritionArtigo { get; set; }

        public double total { get; set; }
        
        public linhaCompra(int _id, string _id_compra, double _qdd, int _artigo, double _total)
        //ctor cria construtor prop cria propriedade
        {
            this.id = _id;
            this.id_compra = _id_compra;
            this.qdd = _qdd;
            this.artigo = _artigo;
            this.total = _total;
        }

        public linhaCompra(double _qdd, int _artigo, string _descritionArtigo, double _total)
        //ctor cria construtor prop cria propriedade
        {        
            this.qdd = _qdd;
            this.artigo = _artigo;
            this.descritionArtigo = _descritionArtigo;
            this.total = _total;
        }

        public linhaCompra()
        {

        }

    }  
}
