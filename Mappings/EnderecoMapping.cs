using AutoMapper;
using IntegraBrasilAPI.Dtos;
using IntegraBrasilAPI.Models;

namespace IntegraBrasilAPI.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}
