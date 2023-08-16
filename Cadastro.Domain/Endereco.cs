﻿using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain
{
    public class Endereco
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
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
