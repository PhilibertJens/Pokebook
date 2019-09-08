using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web
{
    public class Constants
    {
        public Constants()
        {
            /*Enkel deze 4 private fields moeten soms gewijzigd worden*/
            portnumberServer = 44321;
            portnumberClient = 45456;
            hostnameServer = "localhost";
            hostnameClient = "192.168.0.215";

            ApiServerSideAddress = $"https://{hostnameServer}:{portnumberServer}";
            ApiClientSideAddress = $"https://{hostnameClient}:{portnumberClient}";
        }

        private readonly string hostnameServer;
        private readonly string hostnameClient;
        private readonly int portnumberServer;
        private readonly int portnumberClient;
        public string ApiServerSideAddress { get; }
        public string ApiClientSideAddress { get; }


        //public string apiServerSideAddress { get; } = $"https://{hostname}:44321";
        //public string apiClientSideAddress { get; } = "https://192.168.0.215:45456";
    }
}
