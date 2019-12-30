using System.Threading.Tasks;
using TD.Dominio.ViewModel;

namespace TD.Dominio.Aplicacao
{
    public interface IUsuarios
    {
        Task<Usuario> Autenticacao(Login model);
    }
}
