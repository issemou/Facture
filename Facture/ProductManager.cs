using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facture.BO;
using Facture.DAL;

namespace Facture
{
    public class ProductManager
    {
        public ProductRepository repository;
        public ProductManager()
        {
            repository = new ProductRepository();
        }
        public void AddProduct(Product product)
        {
            repository.Add(product);
        }
        public void EditeProduct(Product product,Product newproduct)
        {
            repository.Set(product, newproduct);
        }
        public List<Product> GetProducts()
        {
            return repository.GetAll();
        }

    }
}
