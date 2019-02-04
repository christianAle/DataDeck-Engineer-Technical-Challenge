using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models
{
    public class ApiResponse
    {
        public string Message { get; set; }
        public object Data { get; set; }
    }
}