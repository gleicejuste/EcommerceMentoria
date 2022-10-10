using System;
using AutoMapper;
using EM.Domain.Entidades;
using EM.Domain.Modelos;

namespace EM.Service.Mappers;

public class RequestToDomainProfile : Profile
{
    public RequestToDomainProfile()
    {
        CreateMap<NovoClienteRequest, Cliente>(MemberList.Destination)
            .ForMember(dest => dest.DataCadastro, opt => opt.MapFrom(_ => DateTime.Now));

        CreateMap<NovoTelefoneRequest, Telefone>(MemberList.Destination);
    }
}
