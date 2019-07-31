using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web
{
    public class Constants
    {
        public int Portnumber { get; } = 44321;//poortnummer aanpassen! Ook in js files niet vergeten!
        public string apiLanAddress { get; } = "192.168.0.214:45456";//via deze adres info zijn de api calls beschikbaar voor de lan
        //public string apiLanAddress { get; } = "localhost:44321";
    }
}
