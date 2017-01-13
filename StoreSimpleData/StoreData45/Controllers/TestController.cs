using System.Web.Http;

namespace StoreData45.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string test()
        {
            return "testok";
        }
    }
}
