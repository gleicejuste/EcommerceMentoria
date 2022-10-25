using System;
using AutoMapper;
using EM.Domain.Entidades;
using EM.Domain.Modelos;
using EM.Domain.Util;

namespace EM.Service.Mappers;

public class RequestToDomainProfile : Profile
{
    public RequestToDomainProfile()
    {
        CreateMap<ClienteNovoRequest, Cliente>(MemberList.Destination)
            .ForMember(dest => dest.DataCadastro, opt => opt.MapFrom(_ => DateTime.Now))
            .ForMember(dest => dest.Ativo, opt => opt.MapFrom(_ => true))
            .ForMember(dest => dest.HashSenha, opt => opt.MapFrom(_ => Util.GerarHashSenha(_.HashSenha)));

        CreateMap<ClienteRequest, Cliente>(MemberList.Destination)
            .ForMember(dest => dest.DataCadastro, opt => opt.MapFrom(_ => DateTime.Now))
            .ForMember(dest => dest.Ativo, opt => opt.MapFrom(_ => true));

        CreateMap<TelefoneRequest, Telefone>(MemberList.Destination)
            .ForMember(dest => dest.DataCadastro, opt => opt.MapFrom(_ => DateTime.Now));

        CreateMap<Cliente, ClienteResponse>();

        CreateMap<Telefone, TelefoneResponse>();
    }
}
