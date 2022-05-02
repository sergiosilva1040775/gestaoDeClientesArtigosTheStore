namespace gestaoDeClientesArtigosTheStore.Models
{
    public class compras
    {
        public int id_compras { get; }

        public decimal  valor { get; }

        public string data { get; }

        public int pontos { get; }

        public int id_cliente { get; }

        public int id_funcionario { get; }

        public compras(int _id_compras, decimal _valor, string _data, int _pontos, int _id_cliente, int _id_funcionario)
        //ctor cria construtor prop cria propriedade
        {
            this.id_compras = _id_compras;
            this.valor = _valor;
            this.data = _data;
            this.pontos = _pontos;
            this.id_cliente = _id_cliente;
            this.id_funcionario = _id_funcionario;
        }

        public compras()
        {

        }

    }
}
