using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowskis.DataLayer
{
    public class ApiCollector : IApiCollector
    {
        private string ApiNackowskisKey;
        private string ApiNackowskisBaseAdress;
        public ApiCollector(IConfiguration configuration)
        {
            ApiNackowskisKey = configuration.GetValue<string>("ApiNackowskiKey");
            ApiNackowskisBaseAdress = "http://nackowskis.azurewebsites.net/api/";

    }
}
}
