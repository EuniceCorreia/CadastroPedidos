using Produtos.DTO;

namespace PedidoCarrinho.Services
{
    public class ProdutosClient
    {
        public ProdutosDTO BuscarProduto(int idProduto)
        {
            var httpClient = new HttpClient();

            var urlAplicacao = "https://localhost:7284/";

            var metodo = "api/Produtos/";

            var urlChamada = urlAplicacao + metodo + idProduto;

            var retorno = httpClient.GetAsync(urlChamada).Result;

            if (!retorno.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao buscar produto!");
            }

            var produto = retorno.Content.ReadFromJsonAsync<ProdutosDTO>().Result;

            return produto;
        }
    }
}
