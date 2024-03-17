//using DAL.Api;
//using DAL.DalObject;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL.Implementation
//{
//    public class ClassificationsRepo : IRepository<Classification>
//    {
//        GmachContext context;
//        public ClassificationsRepo(GmachContext context)
//        {
//            this.context = context;
//        }
//        public void Add(Classification item)
//        {
//            context.Classifications.Add(item);
//            context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            foreach(Gmach g in context.Gmaches)
//            {
//                if(g.GmachCode == id)
//                {
//                    var entity = GetById(g.Classifications);
//                    //context.Locations.Remove(entity);
//                    context.SaveChanges();
//                    return;
//                }
//            }
//        }

//        public List<Classification> GetAll()
//        {
//            return context.Classifications.ToList();
//        }

//        public Classification GetById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(int id, Classification item)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
