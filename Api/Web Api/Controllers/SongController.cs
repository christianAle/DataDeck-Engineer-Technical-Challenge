using Api;
using CoreApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_Api.Models;

namespace Web_Api.Controllers
{
  
    public class SongController : ApiController
    {

        ApiResponse apiResp = new ApiResponse();

        public IHttpActionResult Get(string id,string id2)
        {

            try

            {
                var mn = new Manager();

                switch (id.ToLower())
                {

                    case "artis":
                        var song = new Song(1, id2);

                        apiResp = new ApiResponse { Data = mn.RetrieveSongByArtis(song) };


                        break;

                    case "song":
                        var songs = new Song(id2);

                        apiResp = new ApiResponse { Data = mn.RetrieveSongByName(songs) };


                        break;

                    case "genre":

                        apiResp = new ApiResponse { Data = mn.RetrieveSongByGenre(id2) };


                        break;


                    default:

                        var s = new List<Song>();
                        apiResp = new ApiResponse { Data = s };
                        return Ok(apiResp);



                }
                 
                return Ok(apiResp);
            
            }
            catch (Exception bex)
            {
                return InternalServerError();
            }

        }

    }
}
