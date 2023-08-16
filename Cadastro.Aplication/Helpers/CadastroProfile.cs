using AutoMapper;
using Cadastro.Aplication.Dtos;
using Cadastro.Domain;

namespace Cadastro.Aplication.Helpers
{
    public class CadastroProfile : Profile
    {
        public CadastroProfile() 
        {
            CreateMap<Pessoa, PessoaDto>().ReverseMap();
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
            CreateMap<Telefone, TelefoneDto>().ReverseMap();
        }
    }
}
