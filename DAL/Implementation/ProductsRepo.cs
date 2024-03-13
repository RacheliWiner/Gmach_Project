using DAL.Api;
using DAL.DalObject;
using DAL.Models;
using Product = DAL.DalObject.Product;

namespace DAL.Implementation
{
    internal class ProductsRepo : IRepository<Product>
    {
        GmachContext context;
        public ProductsRepo(GmachContext context)
        {
            this.context = context;
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public void Update(int id, Product item)
        {
            var entity = GetById(id);
            context.Products.Add(entity);//מה צריך לעדכן פה?
            entity.ProductName = item.ProductName;
            entity.ProductDescription = item.ProductDescription;
            entity.ProductCode = item.ProductCode;
            entity.Price = item.Price;
            entity.Amount = item.Amount;
            entity.LeftInStock = item.LeftInStock;
            context.SaveChanges();


        }
        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }


        void IRepository<Product>.Delete(int id)
        {
            var entity = GetById(id);
            context.Products.Remove(entity);
            context.SaveChanges();

        }

        void IRepository<Product>.Add(Product item)
        {
            context.Products.Add(item);
            context.SaveChanges();
            return;

        }
    }
}
