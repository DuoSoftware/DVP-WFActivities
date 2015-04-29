using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DVP_Helper;

namespace MvcApplication1.Controllers
{
    public class CallController : ApiController
    {
       

        // POST api/call
        public DVP_Helper.@continue Post(CallData value)
        {

            DVP_Helper.@continue continuecmd = new DVP_Helper.@continue() { app = "CallRouting" };

            return continuecmd;

        }

       
    }
}
