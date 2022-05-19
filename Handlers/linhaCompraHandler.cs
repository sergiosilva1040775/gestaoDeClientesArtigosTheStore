using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoDeClientesArtigosTheStore.Handlers
{
    public class linhaCompraHandler
    {

        Models.linhaCompra linhaCompraModel = new Models.linhaCompra();
        public (int errorId, Models.linhaCompra, string mensagemDeErro) ValidarLinhaCompraInsert(string _id_compra,
            string _id_Artigo,
            string _qdd,
            string _totalLinha)
        {

            if (_id_compra.Length == 0) { return (2, null, "Falta  numero da compra"); }      

            if (_id_Artigo.Length == 0) { return (3, null, "Falta  numero do artigo"); }
            int _id_ArtigoOk = 0;
            int.TryParse(_id_Artigo, out _id_ArtigoOk);
            if (_id_ArtigoOk == 0) { return (3, null, "Falta  numero do artigo"); }


            if (_qdd.Length == 0) { return (4, null, "Falta  quantidade do produto"); }
            double _qddOk = 0;
            double.TryParse(_qdd, out _qddOk);
            if (_qddOk == 0) { return (4, null, "Falta  quantidade do produto"); }


            if (_totalLinha.Length == 0) { return (5, null, "Falta  quantidade da linha"); }
            double _totalLinhaOk = 0;
            double.TryParse(_totalLinha, out _totalLinhaOk);
            if (_totalLinhaOk == 0) { return (5, null, "Valor quantidade da linha incorreto"); }



            linhaCompraModel.id_compra = _id_compra;
            linhaCompraModel.artigo  = _id_ArtigoOk;
            linhaCompraModel.qdd  = _qddOk;
            linhaCompraModel.total  = _totalLinhaOk;

            return (0, linhaCompraModel, null);

        }

        public (int errorId, Models.linhaCompra, string mensagemDeErro) ValidarLinhaCompraUpdate(string _id_linhaCompra,
            string _id_compra,
            string _id_Artigo,
            string _qdd,
            string _totalLinha)
        {

            if (_id_linhaCompra.Length == 0) { return (1, null, "Falta  numero indentificativo da linha da compra"); }
            int _id_linhaCompraOk = 0;
            int.TryParse(_id_linhaCompra, out _id_linhaCompraOk);
            if (_id_linhaCompraOk == 0) { return (1, null, "Falta  numero indentificativo da linha da compra"); }

            if (_id_compra.Length == 0) { return (2, null, "Falta  numero da compra"); }
        

            if (_id_Artigo.Length == 0) { return (3, null, "Falta  numero do artigo"); }
            int _id_ArtigoOk = 0;
            int.TryParse(_id_Artigo, out _id_ArtigoOk);
            if (_id_ArtigoOk == 0) { return (3, null, "Falta  numero do artigo"); }

            if (_qdd.Length == 0) { return (4, null, "Falta  quantidade do produto"); }
            double _qddOk = 0;
            double.TryParse(_qdd, out _qddOk);
            if (_qddOk == 0) { return (4, null, "Falta  quantidade do produto"); }

            if (_totalLinha.Length == 0) { return (5, null, "Falta  quantidade da linha"); }
            double _totalLinhaOk = 0;
            double.TryParse(_totalLinha, out _totalLinhaOk);
            if (_totalLinhaOk == 0) { return (5, null, "Valor quantidade da linha incorreto"); }

            linhaCompraModel.id  = _id_linhaCompraOk;
            linhaCompraModel.id_compra = _id_compra;
            linhaCompraModel.artigo = _id_ArtigoOk;
            linhaCompraModel.qdd = _qddOk;
            linhaCompraModel.total = _totalLinhaOk;

            return (0, linhaCompraModel, null);

        }

        public (int errorId, Models.linhaCompra, string mensagemDeErro) ValidarLinhaCompraoApagar(string _id_linhaCompra)
        {
            if (_id_linhaCompra.Length == 0) { return (1, null, "Falta  numero indentificativo da linha da compra"); }
            int _id_linhaCompraOk = 0;
            int.TryParse(_id_linhaCompra, out _id_linhaCompraOk);
            if (_id_linhaCompraOk == 0) { return (1, null, "Falta  numero indentificativo da linha da compra"); }

            linhaCompraModel.id = _id_linhaCompraOk;

            return (0, linhaCompraModel, null);
        }

    }
}
