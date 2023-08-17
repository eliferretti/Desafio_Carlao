using AutoMapper;
using Cadastro.Aplication.Contratos;
using Cadastro.Aplication.Dtos;
using Cadastro.Domain;
using Cadastro.Persistence.Contratos;
using System;
using System.Threading.Tasks;

namespace Cadastro.Aplication
{
    public class PessoaService : IPessoaService
    {
        private readonly IGenericPersist _genericPersist;

        private readonly IPessoaPersist _pessoaPersist;
        private readonly IMapper _mapper;

        public PessoaService(IGenericPersist genericPersist,
                             IPessoaPersist pessoaPersist,
                             IMapper mapper) 
        { 
            _mapper = mapper;
            _genericPersist = genericPersist;
            _pessoaPersist = pessoaPersist;
        }

        public async Task<PessoaDto> AddPessoa(PessoaDto model)
        {
            var pessoa = _mapper.Map<Pessoa>(model);
            try
            {
                _genericPersist.Add<Pessoa>(pessoa);
                if (await _genericPersist.SaveChangesAsync())
                {
                    var pessoaRetorno = await _pessoaPersist.GetPessoaByIdAsync(pessoa.Id);
                    return _mapper.Map<PessoaDto>(pessoaRetorno);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<PessoaDto> UpdatePessoa(PessoaDto model)
        {
            try
            {
                var pessoa = await _pessoaPersist.GetPessoaByIdAsync(model.Id);
                if (pessoa == null) return null;

                _mapper.Map(model, pessoa);

                _genericPersist.Update(pessoa);
                if (await _genericPersist.SaveChangesAsync())
                {
                    var pessoaRetorno = await _pessoaPersist.GetPessoaByIdAsync(pessoa.Id);
                    return _mapper.Map<PessoaDto>(pessoaRetorno);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> DeletePessoa(int id)
        {
            try
            {
                var pessoa = await _pessoaPersist.GetPessoaByIdAsync(id);

                if (pessoa == null) throw new Exception("Pessoa não encontrada");
                _genericPersist.Delete<Pessoa>(pessoa);
                return await _genericPersist.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<PessoaDto[]> FetchAllPessoasAsync()
        {
            try
            {
                var pessoas = await _pessoaPersist.FetchAllPessoas();
                if (pessoas == null) return null;

                var resultado = _mapper.Map<PessoaDto[]>(pessoas);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PessoaDto[]> FetchPessoasByNomeLike(string nomeLike)
        {
            try
            {
                var pessoas = await _pessoaPersist.FetchByNameLike(nomeLike);
                if (pessoas == null) return null;
                var resultado = _mapper.Map<PessoaDto[]>(pessoas);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PessoaDto> GetPessoaByCpf(string cpf)
        {
            try
            {
                var pessoa = await _pessoaPersist.GetPessoaByCPFAsync(cpf);
                if (pessoa == null) return null;

                var resultado = _mapper.Map<PessoaDto>(pessoa);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PessoaDto> GetPessoaById(int id)
        {
            try
            {
                var pessoa = await _pessoaPersist.GetPessoaByIdAsync(id);
                if (pessoa == null) return null;

                var resultado = _mapper.Map<PessoaDto>(pessoa);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
