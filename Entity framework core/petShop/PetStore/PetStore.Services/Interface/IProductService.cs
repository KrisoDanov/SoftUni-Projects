using PetStore.ServiceModels.Products.InputModels;
using PetStore.ServiceModels.Products.OutputModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Services.Interface
{
    public interface IProductService
    {
        void AddProduct(AddProductInputServiceModel model);

        ICollection<ListAllProductsByProductTypeServiceModels>
            ListAllByProductType(string type);

        ICollection<ListAllProductsByProductTypeServiceModels> GetAll();

        ICollection<ListAllProductByNameServiceModel> SearchByName(string name, bool caseSensitive);

        bool RemoveById(string id);

        bool RemoveByName(string name);

        void EditProduct(string id, EditProductInputServiceModel model);

        
    
    }
}
