using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// vai para o arquivo LoginRequisicaoDto.cs
namespace GerenciadorDeTarefas.Dtos
{
    public class ErroRespostaDto
    {
        public int Status { get; set; }
        public string Erro { get; set; }
    }
}
