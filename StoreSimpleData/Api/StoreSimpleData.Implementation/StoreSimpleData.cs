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
        public AffectedResponse DeleteMindDerivedData(MindDerivedData MindDerivedData)
        {
            return new AffectedResponse() { RowsAffected = db.DeleteMindReceivedData(MindDerivedData) };
        }
        public AffectedResponse DeleteMindReceivedData(MindReceivedData MindReceivedData)
        {
            return new AffectedResponse() { RowsAffected = db.DeleteMindReceivedData(MindReceivedData) };
        }
        public AffectedResponse DeleteMindTarget(MindTarget MindTarget)
        {
            return new AffectedResponse() { RowsAffected = db.DeleteMindTarget(MindTarget) };
        }

        public AffectedResponse InsertMindDerivedData(MindDerivedData MindDerivedData)
        {
            return new AffectedResponse() { RowsAffected = db.InsertMindDerivedData(ConvertItTo.DBMindDerivedData(MindDerivedData)) };
        }

        public AffectedResponse InsertMindReceivedData(MindReceivedData MindReceivedData)
        {
            return new AffectedResponse() { RowsAffected = db.InsertMindReceivedData(ConvertItTo.DBMindReceivedData(MindReceivedData)) };
        }

        public AffectedResponse InsertMindTarget(MindTarget MindTarget)
        {
            return new AffectedResponse() { RowsAffected = db.InsertMindTarget(ConvertItTo.DBMindTarget(MindTarget)) };
        }

        public MindDerivedDatasResponse SelectMindDerivedData()
        {
            return SelectMindDerivedData(null);
        }

        public MindDerivedDatasResponse SelectMindDerivedData(MindDerivedData MindDerivedData)
        {
            return new MindDerivedDatasResponse()
            {
                MindDerivedDatas = db.SelectMindDerivedData(MindDerivedData)
                .Select(data => ConvertItTo.MindDerivedData(data))
                .ToList()
            };
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
        public AffectedResponse UpdateMindDerivedData(MindDerivedData MindDerivedData)
        {
            return new AffectedResponse() { RowsAffected = db.UpdateMindDerivedData(ConvertItTo.DBMindDerivedData(MindDerivedData)) };
        }
        public AffectedResponse UpdateMindReceivedData(MindReceivedData MindReceivedData)
        {
            return new AffectedResponse() { RowsAffected = db.UpdateMindReceivedData(ConvertItTo.DBMindReceivedData(MindReceivedData)) };
        }
        public AffectedResponse UpdateMindTarget(MindTarget MindTarget)
        {
            return new AffectedResponse() { RowsAffected = db.UpdateMindTarget(ConvertItTo.DBMindTarget(MindTarget)) };
        }
    }
}

