namespace gestaoDeClientesArtigosTheStore.Handlers
{
    public class compraHander
    {
        Models.compra compraModel = new Models.compra();


        public (int errorId, Models.compra, string mensagemDeErro) ValidarCompraSelectInicial(string _id_compras,
       string _id_cliente,
    string _id_funcionario)
        {
            if (_id_compras.Length == 0) { return (1, null, "Falta  numero identificador da compra"); }
        
 

   


            if (_id_cliente.Length == 0) { return (5, null, "Falta  numero identificador do cliente"); }
            int _id_clienteOk = 0;
            int.TryParse(_id_cliente, out _id_clienteOk);
            if (_id_clienteOk == 0) { return (5, null, "Falta  numero identificador do cliente"); }


            if (_id_funcionario.Length == 0) { return (6, null, "Falta  numero identificador do funcionario"); }
            int _id_funcionarioOk = 0;
            int.TryParse(_id_funcionario, out _id_funcionarioOk);
            if (_id_funcionarioOk == 0) { return (6, null, "Falta  numero identificador do funcionario"); }


            compraModel.id_compras = _id_compras;
            compraModel.id_cliente = _id_clienteOk;
            compraModel.id_funcionario = _id_funcionarioOk;


            return (0, compraModel, null);

        }


        public (int errorId, Models.compra, string mensagemDeErro) ValidarCompraUpdate(string _id_compras,
            string _valor,
            string _data,
            string _pontos,
            string _id_cliente,
            string _id_funcionario)
        {
            if (_id_compras.Length == 0) { return (1, null, "Falta  numero identificador da compra"); }
      

            if (_valor.Length == 0) { return (2, null, "Falta o valor da compra"); }
            double _valorOk = 0;
            double.TryParse(_valor, out _valorOk);
            if (_valorOk == 0) { return (2, null, "Formato do valor da compra incorrecto"); }


            if (_data.Length == 0) { return (3, null, "Falta  data da compra"); }


            if (_pontos.Length == 0) { return (4, null, "Falta  o valor dos pontos acumulados"); }
            int _pontosOk = 0;
            int.TryParse(_pontos, out _pontosOk);
            if (_pontosOk <= -1) { return (4, null, "Valor dos pontos acumulados incorrecto"); }



            if (_id_cliente.Length == 0) { return (5, null, "Falta  numero identificador do cliente"); }
            int _id_clienteOk = 0;
            int.TryParse(_id_cliente, out _id_clienteOk);
            if (_id_clienteOk == 0) { return (5, null, "Falta  numero identificador do cliente"); }


            if (_id_funcionario.Length == 0) { return (6, null, "Falta  numero identificador do funcionario"); }
            int _id_funcionarioOk = 0;
            int.TryParse(_id_funcionario, out _id_funcionarioOk);
            if (_id_funcionarioOk == 0) { return (6, null, "Falta  numero identificador do funcionario"); }


            compraModel.id_compras = _id_compras;
            compraModel.valor = _valorOk;
            compraModel.data = _data;
            compraModel.pontos = _pontosOk;
            compraModel.id_cliente = _id_clienteOk;
            compraModel.id_funcionario = _id_funcionarioOk;


            return (0, compraModel, null);

        }


        public (int errorId, Models.compra, string mensagemDeErro) ValidarCompraInsert(string _valor,
    string _data,
    string _pontos,
    string _id_cliente,
    string _id_funcionario)
        {
            if (_valor.Length == 0) { return (2, null, "Falta o valor da compra"); }
            double _valorOk = 0;
            double.TryParse(_valor, out _valorOk);
            if (_valorOk == 0) { return (2, null, "Formato do valor da compra incorrecto"); }


            if (_data.Length == 0) { return (3, null, "Falta  data da compra"); }


            if (_pontos.Length == 0) { return (4, null, "Falta  o valor dos pontos acumulados"); }
            int _pontosOk = 0;
            int.TryParse(_pontos, out _pontosOk);
            if (_pontosOk <= -1) { return (4, null, "Valor dos pontos acumulados incorrecto"); }



            if (_id_cliente.Length == 0) { return (5, null, "Falta  numero identificador do cliente"); }
            int _id_clienteOk = 0;
            int.TryParse(_id_cliente, out _id_clienteOk);
            if (_id_clienteOk == 0) { return (5, null, "Falta  numero identificador do cliente"); }


            if (_id_funcionario.Length == 0) { return (6, null, "Falta  numero identificador do funcionario"); }
            int _id_funcionarioOk = 0;
            int.TryParse(_id_funcionario, out _id_funcionarioOk);
            if (_id_funcionarioOk == 0) { return (6, null, "Falta  numero identificador do funcionario"); }


            compraModel.valor = _valorOk;
            compraModel.data = _data;
            compraModel.pontos = _pontosOk;
            compraModel.id_cliente = _id_clienteOk;
            compraModel.id_funcionario = _id_funcionarioOk;


            return (0, compraModel, null);

        }

        public (int errorId, Models.compra, string mensagemDeErro) ValidarCompraApagar(string _id_compras)
        {
            if (_id_compras.Length == 0) { return (1, null, "Falta  numero identificador da compra"); }
       

            compraModel.id_compras = _id_compras;


            return (0, compraModel, null);

        }

    }
}
