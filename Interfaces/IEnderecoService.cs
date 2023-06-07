using IntegraBrasilAPI.Dtos;

namespace IntegraBrasilAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
