using System.Text.RegularExpressions;

namespace gestaoDeClientesArtigosTheStore.Handlers
{

    public class clienteHander
    {
        bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
        }
        bool IsValidCellPhone(string CellPhone)
        {
            Regex objNotNaturalPattern = new Regex("^[0-9]{9}$");
            return objNotNaturalPattern.IsMatch(CellPhone);

        }

        bool IsValidCellNIF(string numeroNIF)
        {
            Regex objNotNaturalPattern = new Regex("^[0-9]{9}$");
            return objNotNaturalPattern.IsMatch(numeroNIF);

        }


        Models.cliente clienteModel = new Models.cliente();
        public (int errorId, Models.cliente, string mensagemDeErro) ValidarClienteInsert(string _nome,
            string _morada,
            string _telefone,
            string _e_mail,
            string _contribuinte,
            string _localidade,
            string _num_cartao,
            string _fotografia,
            string _pass)
        {
            if (_nome.Length == 0) { return (2, null, "Falta  Nome"); }

            if (_morada.Length == 0) { return (3, null, "Falta  Morada"); }

            if (_telefone.Length == 0 || !IsValidCellPhone(_telefone)) { return (4, null, "Formato do contacto incorrecto"); }

            if (_e_mail.Length == 0 || !IsValidEmail(_e_mail)) { return (5, null, "Formato do correio electronico incorrecto"); }

            if (_contribuinte.Length == 0 || !IsValidCellNIF(_contribuinte)) { return (6, null, "Formato do NIF incorrecto"); }

            if (_localidade.Length == 0) { return (7, null, "Falta  Localidade"); }

            if (_num_cartao.Length == 0) { return (8, null, "Número de cartão de cliente incorrecto"); }
            int _num_cartaoOk = 0;
            int.TryParse(_num_cartao, out _num_cartaoOk);
            if (_num_cartaoOk == 0) { return (8, null, "Falta  numero identificador do artigo"); }

            if (_fotografia.Length == 0) { return (9, null, "Falta  Fotografia"); }

            if (_pass.Length == 0) { return (10, null, "Falta  palavra-chave"); }

            clienteModel.nome = _nome;
            clienteModel.morada = _morada;
            clienteModel.telefone = _telefone;
            clienteModel.e_mail = _e_mail;
            clienteModel.contribuinte = _contribuinte;
            clienteModel.localidade = _localidade;
            clienteModel.num_cartao = _num_cartaoOk;
            clienteModel.fotografia = _fotografia;
            clienteModel.pass = _pass;

            return (0, clienteModel, null);

        }

        public (int errorId, Models.cliente, string mensagemDeErro) ValidarClienteUpdate(string _nome,
            string _morada,
            string _telefone,
            string _e_mail,
            string _contribuinte,
            string _localidade,
            string _num_cartao,
            string _fotografia,
            string _pass,
            string _id_cliente)
        {
            if (_id_cliente.Length == 0) { return (1, null, "Falta  numero identificador do cliente"); }
            int _id_clienteOk = 0;
            int.TryParse(_id_cliente, out _id_clienteOk);
            if (_id_clienteOk == 0) { return (1, null, "Falta  numero identificador do cliente"); }

            if (_nome.Length == 0) { return (2, null, "Falta  Nome"); }

            if (_morada.Length == 0) { return (3, null, "Falta  Morada"); }

            if (_telefone.Length == 0 || !IsValidCellPhone(_telefone)) { return (4, null, "Formato do contacto incorrecto"); }

            if (_e_mail.Length == 0 || !IsValidEmail(_e_mail)) { return (5, null, "Formato do correio electronico incorrecto"); }

            if (_contribuinte.Length == 0 || !IsValidCellNIF(_contribuinte)) { return (6, null, "Formato do NIF incorrecto"); }

            if (_localidade.Length == 0) { return (7, null, "Falta  Localidade"); }

            if (_num_cartao.Length == 0) { return (8, null, "Número de cartão de cliente incorrecto"); }
            int _num_cartaoOk = 0;
            int.TryParse(_num_cartao, out _num_cartaoOk);
            if (_num_cartaoOk == 0) { return (8, null, "Falta  numero identificador do artigo"); }

            if (_fotografia.Length == 0) { return (9, null, "Falta  Fotografia"); }

            if (_pass.Length == 0) { return (10, null, "Falta  palavra-chave"); }

            clienteModel.id = _id_clienteOk;
            clienteModel.nome = _nome;
            clienteModel.morada = _morada;
            clienteModel.telefone = _telefone;
            clienteModel.e_mail = _e_mail;
            clienteModel.contribuinte = _contribuinte;
            clienteModel.localidade = _localidade;
            clienteModel.num_cartao = _num_cartaoOk;
            clienteModel.fotografia = _fotografia;
            clienteModel.pass = _pass;

            return (0, clienteModel, null);

        }

        public (int errorId, Models.cliente, string mensagemDeErro) ValidarClienteApagar(string _id_cliente)
        {
            if (_id_cliente.Length == 0) { return (1, null, "Falta  numero identificador do cliente"); }
            int _id_clienteOk = 0;
            int.TryParse(_id_cliente, out _id_clienteOk);
            if (_id_clienteOk == 0) { return (1, null, "Falta  numero identificador do cliente"); }

            clienteModel.id = _id_clienteOk;

            return (0, clienteModel, null);


        }
    }
}
