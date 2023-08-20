using Cadastro.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cadastro.Aplication.Dtos
{
    public class EnderecoDto
    {
        private const string CampoObrigatorio = "O Campo {0} é obrigatório.";
        private const string TamanhoMinMax = "{0} deve ter entre {2} e {1} caracteres.";
        private const string SomenteNumeros = "Somente números são permitidos.";

        public int Id { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        public int IdPessoa { get; set; }

        public PessoaDto Pessoa { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = TamanhoMinMax)]
        public string Rua { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [RegularExpression("^[0-9]+$", ErrorMessage = SomenteNumeros)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(25, MinimumLength = 3, ErrorMessage = TamanhoMinMax)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(25, MinimumLength = 3, ErrorMessage = TamanhoMinMax)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        public EstadosEnum Estado { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [RegularExpression("^[0-9]+$", ErrorMessage = SomenteNumeros)]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "{0} deve ter exatamente 8 números.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(30, MinimumLength = 3, ErrorMessage = TamanhoMinMax)]
        public string Pais { get; set; }

        public string Referencia { get; set; }
        public string PontoReferencia { get; set; }
    }
}
