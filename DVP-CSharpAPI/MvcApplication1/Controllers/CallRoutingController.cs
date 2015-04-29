using DVP_Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class CallRoutingController : ApiController
    {
        public DVP_Helper.hangup Post(CallData value)
        {

            DVP_Helper.hangup hangup = new DVP_Helper.hangup() { cause = "test" };

            return hangup;

        }
    }
}
