using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.ManufacturerViewmodel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class ManufacturerMapper : Profile
    {
        public ManufacturerMapper()
        {
            {
                CreateMap<Manufacturer, ManufacturerListVM>().ReverseMap();
                CreateMap<Manufacturer, ManufacturerCreateVM>().ReverseMap();
                CreateMap<Manufacturer, ManufacturerEditVM>().ReverseMap();
            }
        }
    }
}