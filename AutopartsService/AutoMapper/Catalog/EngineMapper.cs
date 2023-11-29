using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.EngineViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class EngineMapper : Profile
    {
        public EngineMapper()
        {
            CreateMap<Engine, EngineListVM>().ReverseMap();
            CreateMap<Engine, EngineCreateVM>().ReverseMap();
            CreateMap<Engine, EngineEditVM>().ReverseMap();
        }
    }
}