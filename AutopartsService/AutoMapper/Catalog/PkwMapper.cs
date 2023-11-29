using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.PkwViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class PkwMapper : Profile
    {
        public PkwMapper()
        {
            CreateMap<Pkw, PkwListVM>().ReverseMap();
            CreateMap<Pkw, PkwCreateVM>().ReverseMap();
            CreateMap<Pkw, PkwEditVM>().ReverseMap();
        }
    }
}