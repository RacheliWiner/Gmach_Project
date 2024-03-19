using DAL.Api;
using DAL.DalObject;
using ProductRepo = DAL.DalObject.ProductRepo;

namespace DAL.Implementation
{
    internal class ProductsRepo : IRepository<ProductRepo>
    {
        GmachContext context;
        public ProductsRepo(GmachContext context)
        {
            this.context = context;
        }
        public List<ProductRepo> GetAll()
        {
            return context.Products.ToList();
        }
        public void Update(int id, ProductRepo item)
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
        public ProductRepo GetById(int id)
        {
            return context.Products.Find(id);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            context.Products.Remove(entity);
            context.SaveChanges();
        }

        public void Add(ProductRepo item)
        {
            context.Products.Add(item);
            context.SaveChanges();
        }
    }
}


