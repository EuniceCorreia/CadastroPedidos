namespace CadastroPedidos
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data {  get; set; }
        public int Quantidade {  get; set; }
        public int CodigoProduto { get; internal set; }
        public int CodigoUsuario { get; internal set; }
    }
}
