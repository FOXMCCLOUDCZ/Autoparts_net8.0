using AutoMapper;
using AutopartsEntity.Catalog.ViewModels.ProductViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductMapper, ProductListVM>().ReverseMap();
            CreateMap<ProductMapper, ProductCreateVM>().ReverseMap();
            CreateMap<ProductMapper, ProductEditVM>().ReverseMap();
        }
    }
}