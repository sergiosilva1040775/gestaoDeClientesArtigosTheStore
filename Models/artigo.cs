namespace gestaoDeClientesArtigosTheStore.Models
{
    public class artigo
    {
        public int id_artigo { get; }

        public string descricao { get; }

        public string valor_unitario { get; }

        public string stock { get; }

        public artigo(int _id_artigo, string _descricao, string _valor_unitario, string _stock)
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
