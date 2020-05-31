using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Data
{
    public class ProductManage
    {

       public int ID { set; get; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime ProductCreateTime { set; get; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { set; get; }

        /// <summary>
        /// 产品唯一编号
        /// </summary>
        public string ProductNumber { set; get; }

        /// <summary>
        /// 产品试验报告
        /// </summary>
        public string ProductSupplier { set; get; }

    }
}
