using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Data
{
    public class Certificate
    {

        public int ID { set; get; }
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

        /// <summary>
        /// 下次试验日期
        /// </summary>
        public DateTime VNextTestDateTime { set; get; }= DateTime.Now.AddDays(15).Date;

        /// <summary>
        /// 生产厂家
        /// </summary>
        public string Manufacturer { set; get; }
        /// <summary>
        /// 试验人员
        /// </summary>
        public string TestPersonnel { set; get; }


        /// <summary>
        /// 试验报告
        /// </summary>
        [NotNull]
        public string ReprotFileMatching { set; get; }

        /// <summary>
        /// 试验环境
        /// </summary>
        public string TestSurroundings { set; get; } = "温度：30℃  湿度70%";


        /// <summary>
        /// 信息创建时间
        /// </summary>
        public DateTime CreateTime { set; get; }
    }
}
