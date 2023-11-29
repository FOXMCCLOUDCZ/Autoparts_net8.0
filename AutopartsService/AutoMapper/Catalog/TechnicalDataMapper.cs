using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.TechnicalDataViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class TechnicalDataMapper : Profile
    {
        public TechnicalDataMapper()
        {
            CreateMap<TechnicalData, TechnicalDataListVM>().ReverseMap();
            CreateMap<TechnicalData, TechnicalDataCreateVM>().ReverseMap();
            CreateMap<TechnicalData, TechnicalDataEditVM>().ReverseMap();
        }
    }
}