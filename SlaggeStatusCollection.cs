using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlaggeApp
{
    public class SlaggeStatusCollection
    {
        private List<SlaggeStatus> slaggerstatus;

        public List<SlaggeStatus> Slaggerstatus { get => slaggerstatus; set => slaggerstatus = value; }
    }
}
