using AutoMapper;
using BL.BLObject;
using DAL.DALObjects;

namespace BL.Profiles
{
    public class GmachProfile: Profile
    {
        public GmachProfile()
        {
            CreateMap<Gmach,GmachDetailsForClient>().ReverseMap();
        }
    }
}
