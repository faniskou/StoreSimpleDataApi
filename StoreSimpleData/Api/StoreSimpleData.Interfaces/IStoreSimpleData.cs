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
        AffectedResponse InsertMindReceivedData(MindReceivedData MindReceivedData);
        AffectedResponse DeleteMindReceivedData(MindReceivedData MindReceivedData);
        MindReceivedDatasResponse SelectMindReceivedData();
        MindReceivedDatasResponse SelectMindReceivedData(MindReceivedData MindReceivedData);
        AffectedResponse UpdateMindReceivedData(MindReceivedData MindReceivedData);
        //
        AffectedResponse InsertMindDerivedData(MindDerivedData MindDerivedData);
        AffectedResponse DeleteMindDerivedData(MindDerivedData MindDerivedData);
        MindDerivedDatasResponse SelectMindDerivedData();
        MindDerivedDatasResponse SelectMindDerivedData(MindDerivedData MindDerivedData);
        AffectedResponse UpdateMindDerivedData(MindDerivedData MindDerivedData);


    }
}
