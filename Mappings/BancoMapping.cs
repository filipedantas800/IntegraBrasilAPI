﻿using AutoMapper;
using IntegraBrasilAPI.Dtos;
using IntegraBrasilAPI.Models;

namespace IntegraBrasilAPI.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}
