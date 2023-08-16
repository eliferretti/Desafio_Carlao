using Cadastro.Aplication.Contratos;
using Cadastro.Aplication.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cadastro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;
        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try 
            { 
                var pessoas = await _pessoaService.FetchAllPessoasAsync();
                if (pessoas == null) return NoContent();
                return Ok(pessoas);
            } 
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao buscar pessoas. Erro:{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(PessoaDto model)
        {
            try
            {
                var pessoa = await _pessoaService.AddPessoa(model);
                if (pessoa == null) return NoContent();
                return Ok(pessoa);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar adicionar pessoa. Erro:{ex.Message}");
            }
        }

    }
}
