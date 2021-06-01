using GerenciadorDeTarefas.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Controllers
{
    [ApiController] //adicionei ApiContrller
    //PQ adicionar api na frente da barra? resp - para acessar recursos de site
    [Route("api/[controller]")] //adicionei Router("api/[controller]")
    public class LoginController : ControllerBase //adicionei Controller
    {
        private readonly ILogger<LoginController> _logger;//Atributos privados usam _na frente da palavra
        public LoginController(ILogger<LoginController> logger)
        {
            //importante pra mostrar os erros da aplicação
            _logger = logger;
        }

        //criando metodo de API POST
        [HttpPost]
        public IActionResult EfetuarLogin([FromBody] LoginRequisicaoDto requisicao)
        {
            try
            {

            }
            catch(Exception excecao)
            {
                // respostas de erro da API
                _logger.LogError("Ocorreu um erro ao efetuar login", excecao, requisicao);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErroRespostaDto() { 
                    Status = StatusCodes.Status500InternalServerError,
                    Erro = "Ocorreu um erro ao efetuar o login, tente novamente!"
                });
            }
        }
    }
}
