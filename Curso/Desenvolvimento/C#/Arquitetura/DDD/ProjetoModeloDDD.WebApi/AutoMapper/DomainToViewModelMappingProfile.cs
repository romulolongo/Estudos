using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.WebApi.ViewModels;

namespace ProjetoModeloDDD.WebApi.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClientViewModel, Client>()
                .ReverseMap();

            CreateMap<ProductViewModel, Product>()
                .ReverseMap();
        }
    }
}
