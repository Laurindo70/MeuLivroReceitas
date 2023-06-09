using MeuLivroDeReceitas.Application.UseCases.Usuario.Registrar;
using MeuLivroDeReceitas.Comunicacao.Requisicoes;
using MeuLivroDeReceitas.Comunicacao.Respostas;
using Microsoft.AspNetCore.Mvc;

namespace MeuLivroDeReceitas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(RespostaUsuarioRegistradoJson), StatusCodes.Status201Created)]
        public async Task<IActionResult> RegistrarUsuario(
            [FromServices] IRegistrarUsuarioUseCase useCase,
            [FromBody] RequisicaotRegistrarUsuarioJson request)
        {
            var resultado = await useCase.Executar(request);

            return Created(string.Empty, resultado);
        }
    }
}