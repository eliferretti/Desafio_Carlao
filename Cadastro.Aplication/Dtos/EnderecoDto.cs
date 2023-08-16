using Cadastro.Domain.Enums;

namespace Cadastro.Aplication.Dtos
{
    public class EnderecoDto
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public PessoaDto Pessoa { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public EstadosEnum Estado { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public string PontoReferencia { get; set; }
    }
}
