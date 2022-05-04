using System.Text.RegularExpressions;

namespace gestaoDeClientesArtigosTheStore.Handlers
{
    public class funcionarioHander
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


        Models.funcionario funcionarioModel = new Models.funcionario();
        public (int errorId, Models.funcionario, string mensagemDeErro) ValidarFuncionarioInsert(string _numfuncionario,
            string _nome,
            string _contacto,
            string _pass)
        {

            if (_numfuncionario.Length == 0) { return (2, null, "Falta  numero do funcionario"); }
            int _numfuncionarioOk = 0;
            int.TryParse(_numfuncionario, out _numfuncionarioOk);
            if (_numfuncionarioOk == 0) { return (2, null, "Falta  numero do funcionario"); }

            if (_nome.Length == 0) { return (3, null, "Falta  Nome"); }

            if (_contacto.Length == 0 || !IsValidCellPhone(_contacto)) { return (4, null, "Formato do contacto incorrecto"); }

            if (_pass.Length == 0) { return (5, null, "Falta  palavra-chave"); }

            funcionarioModel.numfuncionario = _numfuncionarioOk;
            funcionarioModel.nome = _nome;
            funcionarioModel.contacto = _contacto;
            funcionarioModel.pass = _pass;

            return (0, funcionarioModel, null);

        }

        public (int errorId, Models.funcionario, string mensagemDeErro) ValidarFuncionarioUpdate(string _id_funcionario,
            string _numfuncionario,
            string _nome,
            string _contacto,
            string _pass)
        {

            if (_id_funcionario.Length == 0) { return (1, null, "Falta  numero identificador do funcionario"); }
            int _id_funcionarioOk = 0;
            int.TryParse(_id_funcionario, out _id_funcionarioOk);
            if (_id_funcionarioOk == 0) { return (1, null, "Falta  numero identificador do funcionario"); }

            if (_numfuncionario.Length == 0) { return (2, null, "Falta  numero do funcionario"); }
            int _numfuncionarioOk = 0;
            int.TryParse(_numfuncionario, out _numfuncionarioOk);
            if (_numfuncionarioOk == 0) { return (2, null, "Falta  numero do funcionario"); }

            if (_nome.Length == 0) { return (3, null, "Falta  Nome"); }

            if (_contacto.Length == 0 || !IsValidCellPhone(_contacto)) { return (4, null, "Formato do contacto incorrecto"); }

            if (_pass.Length == 0) { return (5, null, "Falta  palavra-chave"); }

            funcionarioModel.id = _id_funcionarioOk;
            funcionarioModel.numfuncionario = _numfuncionarioOk;
            funcionarioModel.nome = _nome;
            funcionarioModel.contacto = _contacto;
            funcionarioModel.pass = _pass;

            return (0, funcionarioModel, null);

        }

        public (int errorId, Models.funcionario, string mensagemDeErro) ValidarFuncionarioApagar(string _id_funcionario)
        {
            if (_id_funcionario.Length == 0) { return (1, null, "Falta  numero identificador do funcionario"); }
            int _id_funcionarioOk = 0;
            int.TryParse(_id_funcionario, out _id_funcionarioOk);
            if (_id_funcionarioOk == 0) { return (1, null, "Falta  numero identificador do funcionario"); }

            funcionarioModel.id = _id_funcionarioOk;

            return (0, funcionarioModel, null);
        }
    }



}
