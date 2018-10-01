using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessageAPI.Controllers
{
    public class MessageController : ApiController
    {
        // GET: api/Message
        public string Get()
        {
            return "Hello from WebApi";
        }       
    }
}
