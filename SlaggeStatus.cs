using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlaggeApp
{
    public class SlaggeStatus
    {
        string mydate;
        string mytime;
        string containeramount;
        string containerempty;
        string containerfull;

        public string Mydate { get => mydate; set => mydate = value; }
        public string Mytime { get => mytime; set => mytime = value; }
        public string Containeramount { get => containeramount; set => containeramount = value; }
        public string Containerempty { get => containerempty; set => containerempty = value; }
        public string Containerfull { get => containerfull; set => containerfull = value; }
    }
}
