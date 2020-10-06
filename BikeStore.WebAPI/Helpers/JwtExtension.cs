using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BikeStore.WebAPI.Helpers
{
    public static class JwtExtension
    {

        public static void addApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error",message);
            response.Headers.Add("Access-Control-Allow-Origin","*");
            response.Headers.Add("Access-Control-Expose-Header","Application-Error");
        }


    }
}
