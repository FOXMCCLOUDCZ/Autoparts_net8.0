using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.CountryViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class CountryMapper : Profile
    {
        public CountryMapper()
        {
            CreateMap<Country, CountryListVM>().ReverseMap();
            CreateMap<Country, CountryCreateVM>().ReverseMap();
            CreateMap<Country, CountryEditVM>().ReverseMap();
        }
    }
}