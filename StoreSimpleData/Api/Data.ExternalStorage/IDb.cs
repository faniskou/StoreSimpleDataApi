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
        //
        int InsertMindTrainedData(MindTrainedData MindTrainedData);
        int DeleteMindTrainedData(object MindTrainedData);
        List<MindTrainedData> SelectMindTrainedData();
        List<MindTrainedData> SelectMindTrainedData(object MindTrainedData);
        int UpdateMindTrainedData(object MindTrainedData);
        //
        int InsertMindReceivedData(MindReceivedData MindReceivedData);
        int DeleteMindReceivedData(object MindReceivedData);
        List<MindReceivedData> SelectMindReceivedData();
        List<MindReceivedData> SelectMindReceivedData(object MindReceivedData);
        int UpdateMindReceivedData(object MindReceivedData);

    }

}
