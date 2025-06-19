using MovimentoPedido.DTO;

namespace MovimentoPedido.Services
{
    public class UsuariosClient
    {
        public UsuariosDTO BuscarUsuario(int id_Usuario)
        {
            var httpClient = new HttpClient();

            var urlAplicacao = "http://localhost:7151/";

            var metodo = "api/Usuarios/";

            var urlChamada = urlAplicacao + metodo + id_Usuario;

            var retorno = httpClient.GetAsync(urlChamada).Result;

            if (!retorno.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao buscar Usuario!");
            }

            var usuario = retorno.Content.ReadFromJsonAsync<UsuariosDTO>().Result;

            return usuario;
        }
    }
}
