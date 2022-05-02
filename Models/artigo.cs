namespace gestaoDeClientesArtigosTheStore.Models
{
    public class artigo
    {
        public int id_artigo { get; }

        public string descricao { get; }

        public decimal  valor_unitario { get; }

        public decimal stock { get; }

        public artigo(int _id_artigo, string _descricao, decimal _valor_unitario, decimal _stock)
        //ctor cria construtor prop cria propriedade
        {
            this.id_artigo = _id_artigo;
            this.descricao = _descricao;
            this.valor_unitario = _valor_unitario;
            this.stock = _stock;
        }

        public artigo()
        {

        }

    }
}
