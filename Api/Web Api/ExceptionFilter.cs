using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;

namespace Web_Api
{
    public class ExceptionFilter:ExceptionFilterAttribute
    {
        //public override void OnException(HttpActionExecutedContext context)
        //{
        //    if (context.Exception is BussinessException)
        //    {
        //        var bex = (BussinessException)context.Exception;

        //        var json = JsonConvert.SerializeObject(bex);

        //        var response = new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };

        //        context.Response = response;
        //    }
        //}

    }
}