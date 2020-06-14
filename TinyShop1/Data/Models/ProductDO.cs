using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class ProductDO
    {

        [Key] public long ID { get; set; }
        //产品编号
        [StringLength(100)] public string ProductNmuber { get; set; }
        //产品名称
        [StringLength(100)] public string ProductName { get; set; }
        //产品类型
        [StringLength(100)] public string ProductType { get; set; }
        //产品价格
        [StringLength(100)] public double Price { get; set; }
    }
}
