using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cadastro.Aplication.Dtos
{
    public class PessoaDto
    {
        public int Id { get; set; }
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Intervalo permitido entre 3 e 50 caracteres.")]
        public string NomeCompleto { get; set; }
        public GeneroEnum Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public List<EnderecoDto> Enderecos { get; set; }
        public List<TelefoneDto> Telefones { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public EstadoCivilEnum EstadoCivil { get; set; }
        public string Profissao { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
