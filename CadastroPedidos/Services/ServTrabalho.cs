using Trabalho;
using Trabalho.Infra;

namespace Trabalho
{
    public interface IServTrabalho
    {
        TrabalhoDTO Trabalho(int id);
    }

    public class ServTrabalho : IServTrabalho
    {
        private DataContext _dataContext;

        public ServTrabalho()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
        }

        public TrabalhoDTO Trabalho(int id)
        {
            var trabalhoDto = new TrabalhoDTO()
            {
                Texto = "TRABALHO ARQUITETURA - LOJA DE SAPATINHOS"
            };

            return trabalhoDto;
        }
    }
}
