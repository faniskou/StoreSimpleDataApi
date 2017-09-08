using StoreSimpleData.Types;
using System.Collections.Generic;

namespace StoreSimpleData.Interfaces
{
    public interface IStoreSimpleData
    {
        InsertSingleResponse InsertMindTarget(MindTargetInsert MindTargetInsert);
        AffectedResponse DeleteMindTarget(MindDelete MindDelete);
        MindTargetsResponse SelectMindTarget();
        MindTargetsResponse SelectMindTarget(MindTarget MindTarget);
        AffectedResponse UpdateMindTarget(MindTarget MindTarget);
        //
        InsertSingleResponse InsertMindTrainedData(MindTrainedDataInsert MindTrainedDataInsert);
        AffectedResponse DeleteMindTrainedData(MindDelete MindDelete);
        MindTrainedDatasResponse SelectMindTrainedData();
        MindTrainedDatasResponse SelectMindTrainedData(MindTrainedData MindTrainedData);
        AffectedResponse UpdateMindTrainedData(MindTrainedData MindTrainedData);
        //
        InsertSingleResponse InsertMindReceivedData(MindReceivedDataInsert MindReceivedDataInsert);
        AffectedResponse DeleteMindReceivedData(MindDelete MindDelete);
        MindReceivedDatasResponse SelectMindReceivedData();
        MindReceivedDatasResponse SelectMindReceivedData(MindReceivedData MindReceivedData);
        AffectedResponse UpdateMindReceivedData(MindReceivedData MindReceivedData);


    }
}
