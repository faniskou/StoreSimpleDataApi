using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ExternalStorage
{
    public interface IDb
    {
        int InsertMindTarget(MindTarget MindTarget);
        int DeleteMindTarget(object MindTarget);
        List<MindTarget> SelectMindTarget();
        List<MindTarget> SelectMindTarget(object MindTarget);
        int UpdateMindTarget(object MindTarget);
    }
}
