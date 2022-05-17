namespace gestaoDeClientesArtigosTheStore.Models
{
    public class artigo
    {

        public int id_artigo { get; set; }

        public string descricao { get; set; }

        public double   valor_unitario { get; set; }

        public double stock { get; set; }

        public artigo(int _id_artigo, string _descricao, double _valor_unitario, double _stock)
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
