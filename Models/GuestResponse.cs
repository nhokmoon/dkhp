using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dkhp.Models
{
    public class GuestResponse
    {
        public string msv { get; set; }
        public string name { get; set; }
        public string Class { get; set; }
        public string dateofbirth { get; set; }
        public bool? WillAttend { get; set; }
    }
}
