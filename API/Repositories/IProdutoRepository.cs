using Models;

//Feito por Eduardo Miranda CB3026604 & Cauã Barros CB3025179

namespace API.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> AddAsync(Produto produto);
        Task<Produto?> GetByIdAsync(int id);
        Task<IEnumerable<Produto>> GetAllAsync();  
        Task UpdateAsync(Produto produto, int usuarioId);
        Task<bool> DeleteAsync(int id);
    }
}
