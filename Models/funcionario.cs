namespace gestaoDeClientesArtigosTheStore.Models
{
    public class funcionario
    {
        public int id { get; }

        public string numfuncionario { get; }

        public string pass { get; }

        public string nome { get; }

        public string contacto { get; }
        
        public funcionario(int _id, string _numfuncionario, string _pass, string _nome, string _contacto)
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
