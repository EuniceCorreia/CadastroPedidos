using CadastroPedidos;
using CadastroUsuario;
using CatalogoProdutos;
using MovimentoPedido;
using MovimentoPedido.Services;
using Template.Infra;
using Trabalho;

namespace Services
{
    public class PedidoDomain
    {
        public DataContext _dataContext;
        public ProdutosClient _produtosClient;
        public UsuariosClient _usuariosClient;


        public PedidoDomain()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
            _produtosClient = new ProdutosClient();
            _usuariosClient = new UsuariosClient();


        }

        public void CriarPedido(InserirPedidoDTO dadosDoPedido)
        {
            var produto = _produtosClient.BuscarProduto(dadosDoPedido.CodigoProduto);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado!");
            }

            var usuario = _usuariosClient.BuscarUsuario(dadosDoPedido.CodigoUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado!");

            }

            var pedido = new Pedido
            {

                CodigoUsuario = dadosDoPedido.CodigoUsuario,
                CodigoProduto = dadosDoPedido.CodigoProduto,
                Data = dadosDoPedido.Data,
                Quantidade = dadosDoPedido.Quantidade

            };
          

            _dataContext.Add(pedido);

            _dataContext.SaveChanges();
        }

        public void ExcluirPedido(ExcluirPedidoDTO dadosDoPedido)
        {
            var pedido = _dataContext.Pedidos.Find(dadosDoPedido.Id);
            if (pedido == null)
            {
                throw new Exception("Pedido não encontrado!");
            }


            _dataContext.Remove(pedido);

            _dataContext.SaveChanges();
        }
        public List<Pedido> BuscarPorUsuario(int codigoUsuario)
        {
            var listaPedidos = _dataContext.Pedidos.Where(p => p.CodigoUsuario == codigoUsuario).ToList();

            return listaPedidos;
        }
    }
}
