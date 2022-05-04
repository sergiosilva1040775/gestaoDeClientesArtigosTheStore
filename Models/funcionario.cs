namespace gestaoDeClientesArtigosTheStore.Models
{
    public class funcionario
    {
        public int id { get; set; }

        public int numfuncionario { get; set; }

        public string pass { get; set; }

        public string nome { get; set; }

        public string contacto { get; set; }

        public funcionario(int _id, int  _numfuncionario, string _pass, string _nome, string _contacto)
        //ctor cria construtor prop cria propriedade
        {
            this.id = _id;
            this.numfuncionario = _numfuncionario;
            this.pass = _pass;
            this.nome = _nome;
            this.contacto = _contacto;
        }

        public funcionario()
        {

        }

    }
}
