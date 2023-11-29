using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.OeViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class OeMapper : Profile
    {
        public OeMapper()
        {
            CreateMap<Oe, OeListVM>().ReverseMap();
            CreateMap<Oe, OeCreateVM>().ReverseMap();
            CreateMap<Oe, OeEditVM>().ReverseMap();
        }
    }
}