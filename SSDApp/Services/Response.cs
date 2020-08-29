using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSDApp.Services
{
    public class Response
    {
        public bool error { get; set; }
        public object data { get; set; }
        public string version { get; set; }
        public string env { get; set; }
    }
}