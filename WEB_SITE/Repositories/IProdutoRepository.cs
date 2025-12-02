using Models;

//Feito por Eduardo Miranda CB3026604 & Cauã Barros CB3025179

namespace WEB_SITE.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto?> AddAsync(Produto produto, int usuarioId);
        Task<Produto[]> GetAllAsync();
        Task<Produto?> GetByIdAsync(int id);
        Task<Produto?> UpdateAsync(Produto produto, int usuarioId);
        Task<bool> DeleteAsync(int id);
    }
}
