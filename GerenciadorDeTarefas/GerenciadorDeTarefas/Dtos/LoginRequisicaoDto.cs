using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Dtos

    // Aquivo criado somente para fazer as requisições de login
{
    public class LoginRequisicaoDto
    {
        //Objetos de entrada
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
