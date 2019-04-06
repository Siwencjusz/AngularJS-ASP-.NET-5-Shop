using AutoMapper;
using Shop.EntityFramework.Entities;
using Shop.Services.Dto;
using Shop.Services.Interfaces;

namespace SimpleTaskSystem
{
    internal static class DtoMappings
    {
        public static void Map(IMapperConfigurationExpression mapper)
        {
            //I specified mapping for AssignedPersonId since NHibernate does not fill Task.AssignedPersonId
            //If you will just use EF, then you can remove ForMember definition.

            mapper.CreateMap<Author, AuthorDto>();
            mapper.CreateMap<Publisher, PublisherDto>();
            mapper.CreateMap<Carrier, CarrierDto>();
            mapper.CreateMap<Cover, CoverDto>();
            mapper.CreateMap<RelEdition, RelEditionDto>();
            mapper.CreateMap<Book, BookDto>().ForMember(dest => dest.Author,
        opt => opt.MapFrom(src => src.Author.Name))
        .ForMember(dest => dest.Publisher,
        opt => opt.MapFrom(src => src.Publisher.Name));

            //mapper.ini;

            //Mapper.AssertConfigurationIsValid();

        }
    }
}
