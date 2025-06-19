namespace CatalogoProdutos
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Tamanho {  get; set; }

        public int QtdeEstoque { get; set; }

        public decimal Preco { get; set; }

        public string Descricao  { get; set; }

        public bool Disponibilidade {  get; set; }
    }
}
