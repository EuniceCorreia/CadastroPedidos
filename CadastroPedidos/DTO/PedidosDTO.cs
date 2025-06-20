namespace Pedidos.DTO
{
    public class InserirPedidosDTO
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }

        public int CodigoUsuario { get; set; }

        public DateTime Data { get; set; }

        public int Quantidade { get; set; }
    }
    public class ExcluirPedidosDTO
        {

        public int Id { get; set; }

        }
}
