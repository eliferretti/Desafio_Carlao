namespace Cadastro.Aplication.Dtos
{
    public class TelefoneDto
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public PessoaDto Pessoa { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
    }
}
