using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Test.API.Models;

namespace Test.API.Controllers
{
    [EnableCors(origins: "http://localhost:60782,http://localhost", headers: "*", methods: "*")]
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Json(new List<User>
            {
                new User { Id = 1, FirstName = "Panit", LastName = "Jantamas", Address = "xxxx" },
                new User { Id = 2, FirstName = "Nattawut", LastName = "Tammaratmetee", Address = "xxxx" },
                new User { Id = 3, FirstName = "Test", LastName = "Test", Address = "Test" }
            });
        }

        [Route("search")]
        [HttpGet]
        public IHttpActionResult Search(int? page = null, int? limit = null, string sortBy = null, string direction = null, string searchString = null)
        {
            //int total;
            //var records = new GridModel().GetPlayers(page, limit, sortBy, direction, searchString, out total);
            //return Json(new { records, total }, JsonRequestBehavior.AllowGet);

            return Json(new { });
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Save(User user)
        {
            return Json(new { message = "user has been saved successfully" });
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult Edit(User user)
        {
            return Json(new List<User>
            {
                new User { Id = 1, FirstName = "Panit", LastName = "Jantamas", Address = "xxxx" },
                new User { Id = 2, FirstName = "Nattawut", LastName = "Tammaratmetee", Address = "xxxx" },
                new User { Id = 3, FirstName = "Test", LastName = "Test", Address = "Test" }
            });
        }

        [Route("")]
        [HttpDelete]
        public IHttpActionResult Delete(User user)
        {
            return Json(new List<User>
            {
                new User { Id = 1, FirstName = "Panit", LastName = "Jantamas", Address = "xxxx" },
                new User { Id = 2, FirstName = "Nattawut", LastName = "Tammaratmetee", Address = "xxxx" },
                new User { Id = 3, FirstName = "Test", LastName = "Test", Address = "Test" }
            });
        }
    }
}