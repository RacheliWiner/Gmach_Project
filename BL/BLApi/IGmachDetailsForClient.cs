using BL.BLObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLApi
{
    public interface IGmachDetailsForClient
    {
        List<GmachDetailsForClient> GetAllGmachs();
        GmachDetailsForClient GetGmachDetailsById(int id);
    }
}
