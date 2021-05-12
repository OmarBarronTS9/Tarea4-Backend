using BACKEND_TAREA3.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACKEND_TAREA3.Models;

namespace BACKEND_TAREA3.Backend
{
    public class ProductsSC : BaseSC
    {
        public IQueryable<Product> GetProduct()
        {
            return DbContext.Products.AsQueryable();
        }

        public Product GetProductByID(int ID)
        {
            return DbContext.Products.Where(w => w.ProductId == ID).FirstOrDefault();
        }

        public void  UpdateProduct(int ID, decimal Price, short UnitInStock)
        {
            var Product = GetProductByID(ID);
            Product.UnitPrice = Price;
            Product.UnitsInStock = UnitInStock;
            DbContext.Products.Update(Product);
            DbContext.SaveChanges();
        }

        public void AddProduct(ProductModel newProduct)
        {
            var newProductReg = new Product();
            newProductReg.ProductName = newProduct.ProductName;
            newProductReg.UnitPrice = newProduct.UnitPrice;
            newProductReg.UnitsInStock = newProduct.UnitsInStock;

            DbContext.Products.Add(newProductReg);
            DbContext.SaveChanges();

        }

        public void DeleteProduct(ProductModel DProduct)
        {
            var currentProduct = DbContext.Products.Where(W => W.ProductId == DProduct.ProductID).FirstOrDefault();
            DbContext.Products.Remove(currentProduct);
            DbContext.SaveChanges();
        }
    }
}
