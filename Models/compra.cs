namespace gestaoDeClientesArtigosTheStore.Models
{
    public class compra
    {
        public int id_compras { get; set; }

        public double  valor { get; set; }

        public string data { get; set; }

        public int pontos { get; set; }

        public int id_cliente { get; set; }

        public int id_funcionario { get; set; }

        public compra(int _id_compras, double _valor, string _data, int _pontos, int _id_cliente, int _id_funcionario)
        //ctor cria construtor prop cria propriedade
        {
            this.id_compras = _id_compras;
            this.valor = _valor;
            this.data = _data;
            this.pontos = _pontos;
            this.id_cliente = _id_cliente;
            this.id_funcionario = _id_funcionario;
        }

        public compra()
        {

        }

    }
}
