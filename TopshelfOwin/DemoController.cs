using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TopshelfOwin
{
    public class DemoController : ApiController
    {
        public string Get()
        {
            return "This is a self-hosted web api application!";
        }
    }
}
