using CatalogoProdutos;
using CadastroUsuario;

namespace MovimentoPedido
{
    public class InserirPedidoDTO
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }

        public int CodigoUsuario { get; set; }

        public DateTime Data { get; set; }

        public int Quantidade { get; set; }
    }
    public class ExcluirPedidoDTO
        {
        internal object?[]? Id;

        public int CodigoPedido { get; set; }
        }
}
