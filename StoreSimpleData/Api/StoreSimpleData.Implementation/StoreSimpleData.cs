using System;
using StoreSimpleData.Interfaces;
using StoreSimpleData.Types;
using System.Linq;
using DataBS = Data.ExternalStorage;

namespace StoreSimpleData.Implementation
{
    public class StoreSimpleData : IStoreSimpleData
    {
        readonly DataBS.IDb db;
        public StoreSimpleData(string dbcon)
        {
            db = new DataBS.Db(dbcon);
        }
        public AffectedResponse DeleteMindReceivedData(MindReceivedData MindReceivedData)
        {
            return new AffectedResponse() { RowsAffected = db.DeleteMindTrainedData(MindReceivedData) };
        }
        public AffectedResponse DeleteMindTrainedData(MindTrainedData MindTrainedData)
        {
            return new AffectedResponse() { RowsAffected = db.DeleteMindTrainedData(MindTrainedData) };
        }
        public AffectedResponse DeleteMindTarget(MindTarget MindTarget)
        {
            return new AffectedResponse() { RowsAffected = db.DeleteMindTarget(MindTarget) };
        }

        public AffectedResponse InsertMindReceivedData(MindReceivedData MindReceivedData)
        {
            return new AffectedResponse() { RowsAffected = db.InsertMindReceivedData(ConvertItTo.DBMindReceivedData(MindReceivedData)) };
        }

        public AffectedResponse InsertMindTrainedData(MindTrainedData MindTrainedData)
        {
            return new AffectedResponse() { RowsAffected = db.InsertMindTrainedData(ConvertItTo.DBMindTrainedData(MindTrainedData)) };
        }

        public AffectedResponse InsertMindTarget(MindTarget MindTarget)
        {
            return new AffectedResponse() { RowsAffected = db.InsertMindTarget(ConvertItTo.DBMindTarget(MindTarget)) };
        }

        public MindReceivedDatasResponse SelectMindReceivedData()
        {
            return SelectMindReceivedData(null);
        }

        public MindReceivedDatasResponse SelectMindReceivedData(MindReceivedData MindReceivedData)
        {
            return new MindReceivedDatasResponse()
            {
                MindReceivedDatas = db.SelectMindReceivedData(MindReceivedData)
                .Select(data => ConvertItTo.MindReceivedData(data))
                .ToList()
            };
        }
        public MindTrainedDatasResponse SelectMindTrainedData()
        {
            return SelectMindTrainedData(null);
        }

        public MindTrainedDatasResponse SelectMindTrainedData(MindTrainedData MindTrainedData)
        {
            return new MindTrainedDatasResponse()
            {
                MindTrainedDatas = db.SelectMindTrainedData(MindTrainedData)
                .Select(data => ConvertItTo.MindTrainedData(data))
                .ToList()
            };
        }
        public MindTargetsResponse SelectMindTarget()
        {
            return SelectMindTarget(null);
        }

        public MindTargetsResponse SelectMindTarget(MindTarget MindTarget)
        {
            return new MindTargetsResponse()
            {
                MindTargets = db.SelectMindTarget(MindTarget)
                .Select(data => ConvertItTo.MindTarget(data))
                .ToList()
            };
        }
        public AffectedResponse UpdateMindReceivedData(MindReceivedData MindReceivedData)
        {
            return new AffectedResponse() { RowsAffected = db.UpdateMindReceivedData(ConvertItTo.DBMindReceivedData(MindReceivedData)) };
        }
        public AffectedResponse UpdateMindTrainedData(MindTrainedData MindTrainedData)
        {
            return new AffectedResponse() { RowsAffected = db.UpdateMindTrainedData(ConvertItTo.DBMindTrainedData(MindTrainedData)) };
        }
        public AffectedResponse UpdateMindTarget(MindTarget MindTarget)
        {
            return new AffectedResponse() { RowsAffected = db.UpdateMindTarget(ConvertItTo.DBMindTarget(MindTarget)) };
        }
    }
}

