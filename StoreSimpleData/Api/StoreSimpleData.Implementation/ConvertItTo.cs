using StoreSimpleData.Types;
using DataBS = Data.ExternalStorage;

namespace StoreSimpleData.Implementation
{
    internal static class ConvertItTo
    {
        internal static MindTarget MindTarget(DataBS.MindTarget inp)
        {
            return new MindTarget { Id = inp.Id, Target = inp.Target };
        }
        internal static MindReceivedData MindReceivedData(DataBS.MindReceivedData inp)
        {
            return new MindReceivedData { Id = inp.Id, Details=inp.Details, MaxTarget = inp.MaxTarget, Score = inp.Score , Title = inp.Title };
        }
        internal static MindTrainedData MindTrainedData(DataBS.MindTrainedData inp)
        {
            return new MindTrainedData { Id = inp.Id, Details = inp.Details, Target = inp.Target , Approved = inp.Approved, Title = inp.Title };
        }
        internal static DataBS.MindTarget DBMindTarget(MindTarget inp)
        {
            return new DataBS.MindTarget { Id = inp.Id, Target = inp.Target };
        }
        internal static DataBS.MindReceivedData DBMindReceivedData(MindReceivedData inp)
        {
            return new DataBS.MindReceivedData { Id = inp.Id, Details = inp.Details, MaxTarget = inp.MaxTarget ?? 0, Score = inp.Score ?? 0, Title = inp.Title };
        }
        internal static DataBS.MindTrainedData DBMindTrainedData(MindTrainedData inp)
        {
            return new DataBS.MindTrainedData { Id = inp.Id , Details = inp.Details, Target = inp.Target ?? 0, Approved = inp.Approved ?? false, Title = inp.Title };
        }

        internal static DataBS.MindTarget DBMindTargetInsert(MindTargetInsert inp)
        {
            return new DataBS.MindTarget { Target = inp.Target };
        }
        internal static DataBS.MindReceivedData DBMindReceivedDataInsert(MindReceivedDataInsert inp)
        {
            return new DataBS.MindReceivedData { Details = inp.Details, MaxTarget = inp.MaxTarget ?? 0, Score = inp.Score ?? 0, Title = inp.Title };
        }
        internal static DataBS.MindTrainedData DBMindTrainedDataInsert(MindTrainedDataInsert inp)
        {
            return new DataBS.MindTrainedData { Details = inp.Details, Target = inp.Target ?? 0, Approved = inp.Approved ?? false, Title = inp.Title };
        }

    }
}
