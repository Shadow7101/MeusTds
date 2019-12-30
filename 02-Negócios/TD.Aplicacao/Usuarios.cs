using System;
using System.Threading.Tasks;
using TD.Dominio.Aplicacao;
using TD.Dominio.ViewModel;

namespace TD.Aplicacao
{
    public class Usuarios : IUsuarios
    {
        public async Task<Usuario> Autenticacao(Login model)
        {
            throw new NotImplementedException();
        }
    }
}
