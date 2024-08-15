using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDevice.pub
{
    public class config
    {
        public string protocol { get; set; }
        public string usertype { get; set; }
        public string control { get; set; }
    }

    public class configProtocol
    {
        public string type { get; set; }
        public string password { get; set; }
        public string user { get; set; }
        public string filepath { get; set; }
    }
}
