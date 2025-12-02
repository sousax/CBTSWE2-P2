using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Feito por Eduardo Miranda CB3026604 & Cauã Barros CB3025179

namespace WINDOWS_FORMS.Repositories
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllAsync();
        Task<Usuario> GetByIdAsync(int id);
        Task AddAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(int id);
    }
}
