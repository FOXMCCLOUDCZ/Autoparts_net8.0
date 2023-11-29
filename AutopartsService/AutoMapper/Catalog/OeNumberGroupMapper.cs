using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.OeNumberGroupViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class OeNumberGroupMapper : Profile
    {
        public OeNumberGroupMapper()
        {
            CreateMap<OeNumberGroup, OeNumberGroupListVM>().ReverseMap();
            CreateMap<OeNumberGroup, OeNumberGroupCreateVM>().ReverseMap();
            CreateMap<OeNumberGroup, OeNumberGroupEditVM>().ReverseMap();
        }
    }
}