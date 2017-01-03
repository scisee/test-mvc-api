using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using Test.API.Models;

namespace Test.API.Controllers
{
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
    }
}