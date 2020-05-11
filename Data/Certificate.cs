using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Data
{
    public class Certificate
    {
        public string Name { set; get; } = "安全帽";

        public string Numbel { set; get; } = "10086";

        public DateTime TestDateTime { set; get; } = DateTime.Now.Date;

        public DateTime VNextTestDateTime { set; get; }= DateTime.Now.AddDays(15).Date;

        public string TestPersonnel { set; get; } = "萧何";
    }
}
