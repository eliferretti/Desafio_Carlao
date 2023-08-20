using Cadastro.Aplication.Helpers;
using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cadastro.Aplication.Dtos
{
    public class PessoaDto
    {
        private const string CampoObrigatorio = "O Campo {0} é obrigatório.";
        private const string TamanhoMinMax = "{0} deve ter entre {2} e {1} caracteres.";
        private const string SomenteNumeros = "Somente números são permitidos.";

        public int Id { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = TamanhoMinMax)]
        public string NomeCompleto { get; set; }
        
        [EnumDataType(typeof(GeneroEnum))]
        public GeneroEnum Genero { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1900-01-01", "2099-12-31", ErrorMessage = "A data deve estar entre 01/01/1900 e 31/12/2099.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 dígitos.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = SomenteNumeros)]
        [CPF(ErrorMessage = "CPF inválido.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        public string RG { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = CampoObrigatorio)]
        public List<EnderecoDto> Enderecos { get; set; }
        
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        public List<TelefoneDto> Telefones { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "Endereço de e-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "{0} deve ter entre 8 e 20 caracteres.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo de senha é obrigatório.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "{0} deve ter entre 8 e 20 caracteres.")]
        [SenhaComplexa(ErrorMessage = "A senha não atende aos critérios de complexidade.")]
        public string Senha { get; set; }

        [EnumDataType(typeof(EstadoCivilEnum))]
        public EstadoCivilEnum EstadoCivil { get; set; }

        [Display(Name = "Profissão")]
        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Intervalo permitido entre 3 e 50 caracteres.")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Intervalo permitido entre 3 e 30 caracteres.")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Intervalo permitido entre 3 e 30 caracteres.")]
        public string Naturalidade { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Intervalo permitido entre 3 e 100 caracteres.")]
        public string Observacoes { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
