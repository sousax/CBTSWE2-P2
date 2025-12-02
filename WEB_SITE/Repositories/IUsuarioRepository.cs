using Models;

//Feito por Eduardo Miranda CB3026604 & Cauã Barros CB3025179

namespace WEB_SITE.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> GetUsuarioByNome(string nome); 
    }
}
