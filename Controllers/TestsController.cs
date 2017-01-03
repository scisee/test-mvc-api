using System.Web.Http;

namespace Test.API.Controllers
{
    [RoutePrefix("")]
    public class TestsController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Json(new { message = "api is working" });
        }
    }
}