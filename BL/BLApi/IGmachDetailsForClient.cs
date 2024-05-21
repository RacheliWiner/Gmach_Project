using BL.BLObject;

namespace BL.BLApi
{
    public interface IGmachDetailsForClient
    {
        List<GmachDetailsForClient> GetAllGmachs();
        GmachDetailsForClient GetGmachDetailsById(int id);
    }
}
