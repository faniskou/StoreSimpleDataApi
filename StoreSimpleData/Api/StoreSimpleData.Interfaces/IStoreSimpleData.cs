using StoreSimpleData.Types;
using System.Collections.Generic;

namespace StoreSimpleData.Interfaces
{
    public interface IStoreSimpleData
    {
        AffectedResponse InsertMindTarget(MindTarget MindTarget);
        AffectedResponse DeleteMindTarget(object MindTarget);
        MindTargetsResponse SelectMindTarget();
        MindTargetsResponse SelectMindTarget(object MindTarget);
        AffectedResponse UpdateMindTarget(object MindTarget);
        //
        AffectedResponse InsertMindReceivedData(MindReceivedData MindReceivedData);
        AffectedResponse DeleteMindReceivedData(object MindReceivedData);
        MindReceivedDatasResponse SelectMindReceivedData();
        MindReceivedDatasResponse SelectMindReceivedData(object MindReceivedData);
        AffectedResponse UpdateMindReceivedData(object MindReceivedData);
        //
        AffectedResponse InsertMindDerivedData(MindDerivedData MindDerivedData);
        AffectedResponse DeleteMindDerivedData(object MindDerivedData);
        MindDerivedDatasResponse SelectMindDerivedData();
        MindDerivedDatasResponse SelectMindDerivedData(object MindDerivedData);
        AffectedResponse UpdateMindDerivedData(object MindDerivedData);


    }
}
