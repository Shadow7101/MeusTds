using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TD.Dominio.Aplicacao;
using TD.Dominio.ViewModel;

namespace TG.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public IUsuarios Usuarios { get; }

        public UsuariosController(IUsuarios usuarios)
        {
            Usuarios = usuarios;
        }


        [HttpPost]
        public async Task<IActionResult> Post(Login model)
        {
            try
            {
                var usuario = await Usuarios.Autenticacao(model);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}