using System.ComponentModel.DataAnnotations;

namespace Cadastro.Aplication.Dtos
{
    public class TelefoneDto
    {
        private const string CampoObrigatorio = "O Campo {0} é obrigatório.";
        private const string TamanhoMinMax = "{0} deve ter entre {2} e {1} caracteres.";
        private const string SomenteNumeros = "Somente números são permitidos.";

        public int Id { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [RegularExpression("^[0-9]+$", ErrorMessage = SomenteNumeros)]
        public int IdPessoa { get; set; }
        public PessoaDto Pessoa { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "{0} deve ter exatamente 2 números.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = SomenteNumeros)]
        public string DDD { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(9, MinimumLength = 8, ErrorMessage = TamanhoMinMax)]
        [RegularExpression("^[0-9]+$", ErrorMessage = SomenteNumeros)]
        public string Numero { get; set; }
    }
}
