using AutoMapper;
using PetSoreModels;
using PetSoreModels.Enumerations;
using PetStore.ServiceModels.Products.InputModels;
using PetStore.ServiceModels.Products.OutputModels;
using System;

namespace PetStore.Mapping
{
    class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<AddProductInputServiceModel, Products>()
                .ForMember(x=>x.productType, y => y.MapFrom(x => Enum.Parse(typeof(ProductType)
                ,x.productType)));

            CreateMap
                <Products, ListAllProductsByProductTypeServiceModels>();

            CreateMap
                <Products, ListAllProductsSericeModel>()
                .ForMember(x => x.ProductType, y => y.MapFrom(
                    x => x.productType.ToString()));

            CreateMap
                <Products, ListAllProductByNameServiceModel>()
                .ForMember(x => x.ProductType
                , y => y.MapFrom(x => x.productType.ToString()));

            CreateMap
                <EditProductInputServiceModel, Products>()
                .ForMember(x => x.productType, y => y.MapFrom
                (x => Enum.Parse(typeof(ProductType), x.productType)));
        }
    }
}
