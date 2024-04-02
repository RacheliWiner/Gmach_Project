using DAL.DALImplementation;
using BL.BLApi;
using BL.BLObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DALObjects;

namespace BL.BLImplementation
{
    public class GmachDetailsForClientRepo : IGmachDetailsForClient
    {
        ClassificationsRepo classificationsRepo;
        GmachRepo gmachRepo;
        LocationsRepo locationsRepo;
        OwnerPasswordRepo ownerPasswordRepo;
        ProductsRepo productsRepo;
        public GmachDetailsForClientRepo(DALManager dalManager)
        {
            this.classificationsRepo = dalManager.classifications;
            this.gmachRepo = dalManager.gmach;
            this.locationsRepo = dalManager.locations;
            this.ownerPasswordRepo = dalManager.ownerPassword;
            this.productsRepo = dalManager.products;
        }

        public List<GmachDetailsForClient> GetAllGmachs()
        {
            List<Gmach> temp = gmachRepo.GetAll();
            List<GmachDetailsForClient> list = new List<GmachDetailsForClient>();
            //for (int i = 0; i < temp.Count; i++)
            //{
            //    list.Add(new GmachDetailsForClientRepo()
            //    {
            //        GmachName = temp[i].GmachName,
            //        Classifications = temp[i].Classifications,
            //        OpeningHours = temp[i].OpeningHours,
            //        PhoneNumber = temp[i].PhoneNumber,
            //        WhatsApp = temp[i].WhatsApp,
            //        Email = temp[i].Email,
            //        MaxTime = temp[i].MaxTime
            //    });

            //}
            return list;
            //throw new NotImplementedException();
        }

        public GmachDetailsForClient GetGmachDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
