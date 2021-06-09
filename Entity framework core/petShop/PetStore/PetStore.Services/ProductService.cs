using AutoMapper;
using AutoMapper.QueryableExtensions;
using PetSore.Common;
using PetSoreModels;
using PetSoreModels.Enumerations;
using PetStore.Data;
using PetStore.ServiceModels.Products.InputModels;
using PetStore.ServiceModels.Products.OutputModels;
using PetStore.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStore.Services
{
    public class ProductService : IProductService
    {
        private readonly PetStoreDbContext dbContext;
        private readonly IMapper mapper;

        public ProductService(PetStoreDbContext dbContext,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public void AddProduct(AddProductInputServiceModel model)
        {
            try
            {
            Products product = mapper.Map<Products>(model);

            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw new ArgumentException("Invalid Product type.");
            }

        }

        public void EditProduct(string id, EditProductInputServiceModel model )
        {
            
            try
            {
                Products product = mapper.Map<Products>(model);

                Products productToEdit = dbContext
                    .Products
                    .Find(id);

                if (productToEdit == null)
                {
                   
                    throw new ArgumentException("Invalid Product Type!");

                }
                productToEdit.Name = product.Name;
                productToEdit.productType = product.productType;
                productToEdit.Price = product.Price;

                dbContext.SaveChanges();

            }
            catch(ArgumentException ae)
            {
                throw ae;
            }
            catch (Exception)
            {

                throw new ArgumentException("Invalid Product Type!");
            }
           
        }


   

        public ICollection<ListAllProductsSericeModel> GetAll()
        {
            var products = dbContext
                .Products
                .ProjectTo<ListAllProductsSericeModel>(mapper.ConfigurationProvider)
                .ToList();

            return products;
        }



        public ICollection<ListAllProductsByProductTypeServiceModels> ListAllByProductType(string type)
        {
            ProductType productType;

            bool hasParsed = Enum.TryParse<ProductType>(type,
                true, out productType);

            if (!hasParsed)
            {
                throw new ArgumentException(ExceptionMessages.InvalidProductType);
            }

            var productsServiceModels = dbContext
                .Products
                .Where(p => p.productType == productType)
                .ProjectTo<ListAllProductsByProductTypeServiceModels>(this.mapper.ConfigurationProvider)
                .ToList();

            return productsServiceModels;
        }

        public bool RemoveById(string id)
        {
            Products productToremove =
                dbContext
                .Products
                .Find(id);
            if (productToremove == null)
            {
                throw new ArgumentException("Product with given Id does not exist!");
            }
            dbContext.Remove(productToremove);
            int rowsAffected = dbContext.SaveChanges();
            bool wasDeleted = rowsAffected == 1;

            return wasDeleted;
        }

        public bool RemoveByName(string name)
        {
            Products productToremove =
                 dbContext
                 .Products
                 .FirstOrDefault(x => x.Name == name);
            if (productToremove == null)
            {
                throw new ArgumentException("Product with given Id does not exist!");
            }
            dbContext.Remove(productToremove);
            int rowsAffected = dbContext.SaveChanges();
            bool wasDeleted = rowsAffected == 1;

            return wasDeleted;
        }

        public ICollection<ListAllProductByNameServiceModel> SearchByName(string name, bool caseSensitive)
        {
            ICollection<ListAllProductByNameServiceModel> products;
            if (caseSensitive)
            {
                products = dbContext
                     .Products
                     .Where(p => p.Name.Contains(name))
                     .ProjectTo<ListAllProductByNameServiceModel>
                     (mapper.ConfigurationProvider)
                     .ToList();

            }
            else
            {

                products = dbContext
                     .Products
                     .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                     .ProjectTo<ListAllProductByNameServiceModel>
                     (mapper.ConfigurationProvider)
                     .ToList();
            }
            return products;
        }

        ICollection<ListAllProductsByProductTypeServiceModels> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
