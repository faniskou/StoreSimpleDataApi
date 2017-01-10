using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ExternalStorage
{
    public interface IDb
    {
        int InsertMindName(MindName mindName);
        int DeleteMindName(object mindName);
        List<MindName> SelectMindName();
        List<MindName> SelectMindName(object mindName);
        int UpdateMindName(object mindName);

    }
}
