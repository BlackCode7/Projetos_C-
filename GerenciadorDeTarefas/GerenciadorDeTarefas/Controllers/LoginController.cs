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
                // Se o usuário não passar os dados corretos retorna este erro
                if (requisicao == null||requisicao.Login == null||requisicao.Senha == null) 
                {
                    return BadRequest(new ErroRespostaDto()
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Erro = "Parâmetros de entrada inválidos"
                    });                        
                }
                // Se o usuário passsar dados corretos retorna mensagem de sucesso
                return Ok("Usuário autenticado com sucesso!");
            }
            catch(Exception excecao)
            {
                // respostas de erro da API login = {requisicao.Login} senha = {requisicao.Senha}
                _logger.LogError($"Ocorreu um erro ao efetuar login: {excecao.Message}", excecao);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErroRespostaDto() { 
                    Status = StatusCodes.Status500InternalServerError,
                    Erro = "Ocorreu um erro ao efetuar o login, tente novamente!"
                });
            }
        }
    }
}
