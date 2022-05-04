namespace gestaoDeClientesArtigosTheStore.Handlers
{
    public class artigoHander
    {
        Models.artigo artigoModel = new Models.artigo();
        public (int errorId, Models.artigo, string mensagemDeErro) ValidarArtigoInsert(string _descricao, string _valor_unitario, string _stock)
        {
            if (_descricao.Length == 0) { return (2, null, "Falta  descricao"); }

            if (_valor_unitario.Length == 0) { return (3, null, "Falta  Valor Unitário"); }
            double _valor_unitarioOutOk = 0;
            double.TryParse(_valor_unitario, out _valor_unitarioOutOk);
            if (_valor_unitarioOutOk == 0) { return (3, null, "Valor Unitário no formato incorreto"); }

            if (_stock.Length == 0) { return (4, null, "Falta  Valor Unitário"); }
            double _stockOk = 0;
            double.TryParse(_stock, out _stockOk);
            if (_stockOk == 0) { return (4, null, "Valor stock incorreto"); }

            artigoModel.descricao = _descricao;
            artigoModel.valor_unitario = _valor_unitarioOutOk;
            artigoModel.stock = _stockOk;

            return (0, artigoModel, null);

        }

        public (int errorId, Models.artigo, string mensagemDeErro) ValidarArtigoUpdate(string _descricao, string _valor_unitario, string _stock, string _id_artigo)
        {
            if (_id_artigo.Length == 0) { return (1, null, "Falta  numero identificador do artigo"); }
            int _id_artigoOk = 0;
            int.TryParse(_id_artigo, out _id_artigoOk);
            if (_id_artigoOk == 0) { return (1, null, "Falta  numero identificador do artigo"); }

            if (_descricao.Length == 0) { return (2, null, "Falta  descricao"); }

            if (_valor_unitario.Length == 0) { return (3, null, "Falta  Valor Unitário"); }
            double _valor_unitarioOutOk = 0;
            double.TryParse(_valor_unitario, out _valor_unitarioOutOk);
            if (_valor_unitarioOutOk == 0) { return (3, null, "Valor Unitário no formato incorreto"); }

            if (_stock.Length == 0) { return (4, null, "Falta  Valor Unitário"); }
            double _stockOk = 0;
            double.TryParse(_stock, out _stockOk);
            if (_stockOk == 0) { return (4, null, "Valor stock incorreto"); }

            artigoModel.id_artigo = _id_artigoOk;
            artigoModel.descricao = _descricao;
            artigoModel.valor_unitario = _valor_unitarioOutOk;
            artigoModel.stock = _stockOk;

            return (0, artigoModel, null);
        }

        public (int errorId, Models.artigo, string mensagemDeErro) ValidarArtigoaApagar(string _id_artigo)
        {
            if (_id_artigo.Length == 0) { return (1, null, "Falta  numero identificador do artigo"); }
            int _id_artigoOk = 0;
            int.TryParse(_id_artigo, out _id_artigoOk);
            if (_id_artigoOk == 0) { return (1, null, "Falta  numero identificador do artigo"); }

            artigoModel.id_artigo = _id_artigoOk;

            return (0, artigoModel, null);


        }
    }

}
