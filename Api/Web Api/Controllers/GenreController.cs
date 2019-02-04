using CoreApi;
using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_Api.Models;

namespace Web_Api.Controllers
{
    public class GenreController : ApiController
    {
        ApiResponse apiResp = new ApiResponse();

        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new Manager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        public IHttpActionResult Get(string id)
        {

            try
            {
                var mn= new Manager();
                var genre = new Genre
                {
                    Name = id
                };

                genre = mn.RetrieveByName(genre);
                apiResp = new ApiResponse();
                apiResp.Data = genre;
                return Ok(apiResp);
            }
            catch (Exception bex)
            {
                return InternalServerError();
            }
          
        }

    }

}
