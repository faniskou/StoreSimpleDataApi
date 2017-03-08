using StoreSimpleData.Types;
using System.Collections.Generic;

namespace StoreSimpleData.Interfaces
{
    public interface IStoreSimpleData
    {
        AffectedResponse InsertMindTarget(MindTargetInsert MindTargetInsert);
        AffectedResponse DeleteMindTarget(MindDelete MindDelete);
        MindTargetsResponse SelectMindTarget();
        MindTargetsResponse SelectMindTarget(MindTarget MindTarget);
        AffectedResponse UpdateMindTarget(MindTarget MindTarget);
        //
        AffectedResponse InsertMindTrainedData(MindTrainedDataInsert MindTrainedDataInsert);
        AffectedResponse DeleteMindTrainedData(MindDelete MindDelete);
        MindTrainedDatasResponse SelectMindTrainedData();
        MindTrainedDatasResponse SelectMindTrainedData(MindTrainedData MindTrainedData);
        AffectedResponse UpdateMindTrainedData(MindTrainedData MindTrainedData);
        //
        AffectedResponse InsertMindReceivedData(MindReceivedDataInsert MindReceivedDataInsert);
        AffectedResponse DeleteMindReceivedData(MindDelete MindDelete);
        MindReceivedDatasResponse SelectMindReceivedData();
        MindReceivedDatasResponse SelectMindReceivedData(MindReceivedData MindReceivedData);
        AffectedResponse UpdateMindReceivedData(MindReceivedData MindReceivedData);


    }
}
