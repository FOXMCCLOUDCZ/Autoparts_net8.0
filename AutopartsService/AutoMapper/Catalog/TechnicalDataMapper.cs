using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.VehicleTechnicalDataViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class TechnicalDataMapper : Profile
    {
        public TechnicalDataMapper()
        {
            CreateMap<VehicleTechnicalData, VehicleTechnicalDataListVM>().ReverseMap();
            CreateMap<VehicleTechnicalData, VehicleTechnicalDataCreateVM>().ReverseMap();
            CreateMap<VehicleTechnicalData, VehicleTechnicalDataEditVM>().ReverseMap();
        }
    }
}