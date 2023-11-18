using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.CurrencyViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class CurrencyMapper : Profile
    {
        public CurrencyMapper()
        {
            CreateMap<Currency, CurrencyListVM>().ReverseMap();
            CreateMap<Currency, CurrencyCreateVM>().ReverseMap();
            CreateMap<Currency, CurrencyEditVM>().ReverseMap();
        }
    }
}