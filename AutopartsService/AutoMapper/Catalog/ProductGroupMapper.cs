using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.ProductGroupViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class ProductGroupMapper : Profile
    {
        public ProductGroupMapper()
        {
            CreateMap<ProductGroup, ProductGroupListVM>().ReverseMap();
            CreateMap<ProductGroup, ProductGroupCreateVM>().ReverseMap();
            CreateMap<ProductGroup, ProductGroupEditVM>().ReverseMap();
        }
    }
}