using DAL.DALApi;
using DAL.DALObjects;

namespace DAL.DALImplementation
{
    public class ProductsRepo : IRepository<Product>
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
            //לעשות דברים אחרים לגמרי
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

        public void Delete(int id)
        {
            var entity = GetById(id);
            context.Products.Remove(entity);
            context.SaveChanges();
        }

        public void Add(Product item)
        {
            context.Products.Add(item);
            context.SaveChanges();
        }
    }
}


