﻿using Cadastro.Aplication.Contratos;
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

        [HttpGet("{cpf}")]
        public async Task<IActionResult> GetByCpf(string cpf)
        {
            try
            {
                var pessoa = await _pessoaService.GetPessoaByCpf(cpf);
                if (pessoa == null) return NoContent();
                return Ok(pessoa);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao pesquisar pessoa. Erro:{ex.Message}");
            }
        }

        [HttpGet("nome/{nomeLike}")]
        public async Task<IActionResult> GetByNomeLike(string nomeLike)
        {
            try
            {
                var pessoas = await _pessoaService.FetchPessoasByNomeLike(nomeLike);
                if (pessoas == null) return NoContent();
                return Ok(pessoas);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao pesquisar pessoas. Erro:{ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PessoaDto model)
        {
            try
            {
                var pessoa = await _pessoaService.UpdatePessoa(id, model);
                if (pessoa == null) return NoContent();
                return Ok(pessoa);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar editar pessoa. Erro:{ex.Message}");
            }
        }

    }
}