using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.ModelViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class ModelMapper : Profile
    {
        public ModelMapper()
        {
            CreateMap<Model, ModelListVM>().ReverseMap();
            CreateMap<Model, ModelCreateVM>().ReverseMap();
            CreateMap<Model, ModelEditVM>().ReverseMap();
        }
    }
}