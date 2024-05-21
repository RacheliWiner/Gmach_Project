using AutoMapper;
using BL.BLApi;
using BL.BLObject;
using DAL.DALApi;
using DAL.DALObjects;
using System.Reflection.Metadata.Ecma335;

namespace BL.BLImplementation
{
    public class GmachDetailsForClientRepo : IGmachDetailsForClient
    {
        //ClassificationsRepo classificationsRepo;
        IRepository<Gmach> gmachRepo;
        IMapper mapper;
        //LocationsRepo locationsRepo;
        //OwnerPasswordRepo ownerPasswordRepo;
        //ProductsRepo productsRepo;


        public GmachDetailsForClientRepo(IRepository<Gmach> dalManager, IMapper mapper)
        {
            //this.classificationsRepo = dalManager.classifications;
            this.gmachRepo = dalManager;
            this.mapper = mapper;
            //this.locationsRepo = dalManager.locations;
            //this.ownerPasswordRepo = dalManager.ownerPassword;
            //this.productsRepo = dalManager.products;
        }
        public GmachDetailsForClientRepo(IRepository<Gmach> dalManager)
        {
            this.gmachRepo = dalManager;
        }


        public List<GmachDetailsForClient> GetAllGmachs()
        {
            List<Gmach> gmachsForClient = gmachRepo.GetAll();
            List<GmachDetailsForClient> list = new List<GmachDetailsForClient>();
            //foreach (var gmach in gmachsForClient)
            //{
            //    GmachDetailsForClient g = mapper.Map<Gmach, GmachDetailsForClient>(gmach);
            //    list.Add(g);
            //}
            //return list;
            for (int i = 0; i < gmachsForClient.Count; i++)
            {
                list.Add(new GmachDetailsForClient()
                {
                    GmachName = gmachsForClient[i].GmachName,
                    Classifications = gmachsForClient[i].Classifications,
                    OpeningHours = gmachsForClient[i].OpeningHours,
                    PhoneNumber = gmachsForClient[i].PhoneNumber,
                    WhatsApp = gmachsForClient[i].WhatsApp,
                    Email = gmachsForClient[i].Email,
                    MaxTime = gmachsForClient[i].MaxTime
                });
            }

            return list;
        }

        //public GmachDetailsForClient GetGmachDetailsById(int id)
        //{
        //    Gmach gmachById = gmachRepo.GetById(id);
        //    GmachDetailsForClient g = mapper.Map<Gmach, GmachDetailsForClient>(gmachById);
        //    return g;


        //}
        public GmachDetailsForClient GetGmachDetailsById(int id)
        {
            Gmach gmachById = gmachRepo.GetById(id);
            if(gmachById == null)
            {
                return null;
            }
            GmachDetailsForClient ans = new GmachDetailsForClient()
            {
                GmachName = gmachById.GmachName,
                Classifications = gmachById.Classifications,
                OpeningHours = gmachById.OpeningHours,
                PhoneNumber = gmachById.PhoneNumber,
                WhatsApp = gmachById.WhatsApp,
                Email = gmachById.Email,
                MaxTime = gmachById.MaxTime
            };

            return ans;
        }
    }

}