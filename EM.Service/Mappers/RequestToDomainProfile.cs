using System;
using AutoMapper;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Mappers;

public class RequestToDomainProfile : Profile
{
    public RequestToDomainProfile()
    {
        CreateMap<ClienteRequest, Cliente>(MemberList.Destination)
            .ForMember(dest => dest.DataCadastro, opt => opt.MapFrom(_ => DateTime.Now))
            .ForMember(dest => dest.Ativo, opt => opt.MapFrom(_ => true));

        CreateMap<TelefoneRequest, Telefone>(MemberList.Destination)
            .ForMember(dest => dest.DataCadastro, opt => opt.MapFrom(_ => DateTime.Now));
    }
}
