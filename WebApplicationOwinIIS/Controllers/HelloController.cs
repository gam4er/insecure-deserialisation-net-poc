using System;
using System.Web.Http;


namespace WebApplicationOwinIIS.Controllers
{
    [RoutePrefix("api/v1/hello")]
    public class HelloController : ApiController
    {
        [HttpGet]
        public String Get()
        {
            return "Hello";
        }

        [HttpPost]
        public void Post(Models.HelloModel body)
        {
            Console.WriteLine(body.Body);
        }
    }
}
