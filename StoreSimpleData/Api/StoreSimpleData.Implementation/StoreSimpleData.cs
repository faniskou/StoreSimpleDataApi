using System;
using StoreSimpleData.Interfaces;
using StoreSimpleData.Types;
using System.Configuration;
using Data.ExternalStorage;
using System.Collections.Generic;

namespace StoreSimpleData.Implementation
{
    public class StoreSimpleData : IStoreSimpleData
    {
        readonly IDb db;
        public StoreSimpleData(string dbcon)
        {
            db = new Db(dbcon);
        }
        public AffectedResponse DeleteMindDerivedData(object MindDerivedData)
        {
            var a = db.DeleteMindReceivedData(MindDerivedData);
            return new AffectedResponse() {RowsAffected = a };
        }
        public AffectedResponse DeleteMindReceivedData(object MindReceivedData)
        {
            throw new NotImplementedException();
        }

        public AffectedResponse DeleteMindTarget(object MindTarget)
        {
            throw new NotImplementedException();
        }

        public AffectedResponse InsertMindDerivedData(Types.MindDerivedData MindDerivedData)
        {
            throw new NotImplementedException();
        }

        public AffectedResponse InsertMindReceivedData(Types.MindReceivedData MindReceivedData)
        {
            throw new NotImplementedException();
        }

        public AffectedResponse InsertMindTarget(Types.MindTarget MindTarget)
        {
            throw new NotImplementedException();
        }


        public MindDerivedDatasResponse SelectMindDerivedData()
        {
            throw new NotImplementedException();
        }

        public MindDerivedDatasResponse SelectMindDerivedData(object MindDerivedData)
        {
            throw new NotImplementedException();
        }

        public MindReceivedDatasResponse SelectMindReceivedData()
        {
            throw new NotImplementedException();
        }

        public MindReceivedDatasResponse SelectMindReceivedData(object MindReceivedData)
        {
            throw new NotImplementedException();
        }

        public MindTargetsResponse SelectMindTarget()
        {
            var datas = db.SelectMindTarget();
            MindTargetsResponse res = new MindTargetsResponse();
            res.MindTargets = new List<Types.MindTarget>();
            foreach (var data in datas)
            {
                Types.MindTarget d = new Types.MindTarget { Id = data.Id, Target = data.Target };
                res.MindTargets.Add(d);
            }
            return res;
        }

        public MindTargetsResponse SelectMindTarget(object MindTarget)
        {
            throw new NotImplementedException();
        }

        public AffectedResponse UpdateMindDerivedData(object MindDerivedData)
        {
            throw new NotImplementedException();
        }

        public AffectedResponse UpdateMindReceivedData(object MindReceivedData)
        {
            throw new NotImplementedException();
        }

        public AffectedResponse UpdateMindTarget(object MindTarget)
        {
            throw new NotImplementedException();
        }
    }
}
