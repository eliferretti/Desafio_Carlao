using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Cadastro.Domain
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public GeneroEnum Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
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
