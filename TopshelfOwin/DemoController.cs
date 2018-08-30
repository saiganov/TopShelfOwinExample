using System.Web.Http;

namespace TopshelfOwin
{
    // http://localhost:8085/api/Demo
    public class DemoController : ApiController
    {
        public string Get()
        {
            return "This is a self-hosted web api application!";
        }
    }
}
