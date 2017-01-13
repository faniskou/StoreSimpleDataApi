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
        [HttpGet]
        public IHttpActionResult hello()
        {
            System.Uri Location = new System.Uri(Request.RequestUri.AbsoluteUri + "./swagger");
            return Redirect(Location);
        }
    }
}
