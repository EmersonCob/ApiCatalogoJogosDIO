using ApiCatalogoJogosDIO.InputModel;
using ApiCatalogoJogosDIO.Services;
using ApiCatalogoJogosDIO.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogosDIO.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        private readonly IJogoService _jogoservice;

        public JogosController(IJogoService jogoservice)
        {
            _jogoservice = jogoservice;
        }

        [HttpGet]
        public async Task<ActionResult<JogoViewModel>> Obter()
        {
            var result = await _jogoservice.Obter(1, 5);
            return Ok(result);
        }
        
        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<JogoViewModel>> Obter(Guid idJogo)
        {
            return Ok();

        }

        [HttpPost]
        public async Task<ActionResult<JogoViewModel>> InserirJogo(object jogo)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpDelete("{idJogo:guid}")]
        public async Task<ActionResult> ApagarJogo(Guid idJogo)
        {
            return Ok();
        }
    }
}
