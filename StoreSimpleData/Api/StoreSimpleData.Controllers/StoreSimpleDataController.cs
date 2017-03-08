using StoreSimpleData.Interfaces;
using StoreSimpleData.Types;
using System.Web.Http;

namespace StoreSimpleData.Controllers
{
    public class StoreSimpleDataController : ApiController
    {
        readonly IStoreSimpleData service;
        public StoreSimpleDataController(IStoreSimpleData serv)
        {
            //   string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            //   IStoreSimpleData serv = new StoreSimpleData(dbcon);
            service = serv;
        }
        //test
        [ActionName("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi";
        }
        //selects
        [ActionName("selectMindTarget")]
        [HttpGet]
        public MindTargetsResponse SelectMindTarget()
        {
            return service.SelectMindTarget();
        }
        [ActionName("selectMindTarget")]
        [HttpPost]
        public MindTargetsResponse SelectMindTarget(MindTarget inp)
        {
            return service.SelectMindTarget(inp);
        }
        [ActionName("selectMindTrainedData")]
        [HttpGet]
        public MindTrainedDatasResponse SelectMindTrainedData()
        {
            return service.SelectMindTrainedData();
        }
        [ActionName("selectMindTrainedData")]
        [HttpPost]
        public MindTrainedDatasResponse SelectMindTrainedData(MindTrainedData inp)
        {
            return service.SelectMindTrainedData(inp);
        }
        [ActionName("selectMindReceivedData")]
        [HttpGet]
        public MindReceivedDatasResponse SelectMindReceivedData()
        {
            return service.SelectMindReceivedData();
        }
        [ActionName("selectMindReceivedData")]
        [HttpPost]
        public MindReceivedDatasResponse SelectMindReceivedData(MindReceivedData inp)
        {
            return service.SelectMindReceivedData(inp);
        }
        //inserts
        [ActionName("insertMindTarget")]
        [HttpPut]
        public AffectedResponse InsertMindTarget(MindTargetInsert MindTargetInsert)
        {
            return service.InsertMindTarget(MindTargetInsert);
        }
        [ActionName("insertMindTrainedData")]
        [HttpPut]
        public AffectedResponse InsertMindTrainedData(MindTrainedDataInsert MindTrainedDataInsert)
        {
            return service.InsertMindTrainedData(MindTrainedDataInsert);
        }
        [ActionName("insertMindReceivedData")]
        [HttpPut]
        public AffectedResponse InsertMindReceivedData(MindReceivedData MindReceivedDataInsert)
        {
            return service.InsertMindReceivedData(MindReceivedDataInsert);
        }
        //update
        [ActionName("updateMindTarget")]
        [HttpPut]
        public AffectedResponse UpdateMindTarget(MindTarget MindTarget)
        {
            return service.UpdateMindTarget(MindTarget);
        }
        [ActionName("updateMindTrainedData")]
        [HttpPut]
        public AffectedResponse UpdateMindTrainedData(MindTrainedData MindTrainedData)
        {
            return service.UpdateMindTrainedData(MindTrainedData);
        }
        [ActionName("updateMindReceivedData")]
        [HttpPut]
        public AffectedResponse UpdateMindReceivedData(MindReceivedData MindReceivedData)
        {
            return service.InsertMindReceivedData(MindReceivedData);
        }
        //deletes
        [ActionName("deleteMindTarget")]
        [HttpDelete]
        public AffectedResponse DeleteMindTarget(MindDelete MindDelete)
        {
            return service.DeleteMindTarget(MindDelete);
        }
        [ActionName("deleteMindTrainedData")]
        [HttpDelete]
        public AffectedResponse DeleteMindTrainedData(MindDelete MindDelete)
        {
            return service.DeleteMindTrainedData(MindDelete);
        }
        [ActionName("deleteMindReceivedData")]
        [HttpDelete]
        public AffectedResponse DeleteMindReceivedData(MindDelete MindDelete)
        {
            return service.DeleteMindReceivedData(MindDelete);
        }


    }
}
