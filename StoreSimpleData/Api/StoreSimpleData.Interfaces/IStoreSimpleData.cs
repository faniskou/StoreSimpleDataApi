using StoreSimpleData.Types;
using System.Collections.Generic;

namespace StoreSimpleData.Interfaces
{
    public interface IStoreSimpleData
    {
        AffectedResponse InsertMindTarget(MindTarget MindTarget);
        AffectedResponse DeleteMindTarget(MindTarget MindTarget);
        MindTargetsResponse SelectMindTarget();
        MindTargetsResponse SelectMindTarget(MindTarget MindTarget);
        AffectedResponse UpdateMindTarget(MindTarget MindTarget);
        //
        AffectedResponse InsertMindTrainedData(MindTrainedData MindTrainedData);
        AffectedResponse DeleteMindTrainedData(MindTrainedData MindTrainedData);
        MindTrainedDatasResponse SelectMindTrainedData();
        MindTrainedDatasResponse SelectMindTrainedData(MindTrainedData MindTrainedData);
        AffectedResponse UpdateMindTrainedData(MindTrainedData MindTrainedData);
        //
        AffectedResponse InsertMindReceivedData(MindReceivedData MindReceivedData);
        AffectedResponse DeleteMindReceivedData(MindReceivedData MindReceivedData);
        MindReceivedDatasResponse SelectMindReceivedData();
        MindReceivedDatasResponse SelectMindReceivedData(MindReceivedData MindReceivedData);
        AffectedResponse UpdateMindReceivedData(MindReceivedData MindReceivedData);


    }
}
