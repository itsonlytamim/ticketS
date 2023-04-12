using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TicketSystem.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/ticketM")]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserServices.Get());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
