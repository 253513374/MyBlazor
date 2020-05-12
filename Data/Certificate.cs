using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Data
{
    public class Certificate
    {
        public string Guid { set; get; }

        
        /// <summary>
        /// 所属单位
        /// </summary>
        public string TD { set; get; }

        /// <summary>
        /// 校验单位
        /// </summary>
        public string ToTD { set; get; } 
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { set; get; } 

        /// <summary>
        /// 产品编号
        /// </summary>
        public string Numbel { set; get; } 

        /// <summary>
        /// 试验日期
        /// </summary>
        public DateTime TestDateTime { set; get; } = DateTime.Now.Date;

        public DateTime VNextTestDateTime { set; get; }= DateTime.Now.AddDays(15).Date;

        /// <summary>
        /// 试验人员
        /// </summary>
        public string TestPersonnel { set; get; }
    }
}
