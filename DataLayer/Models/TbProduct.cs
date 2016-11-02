using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class TbProduct
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Des { get; set; }
        public string Tag { get; set; }
        public int Unit_id { get; set; }
        public long Group_id { get; set; }
        public string Barcode { get; set; }
        public virtual TbGroup TbGroup { get; set; }
        public virtual TbUnit TbUnit { get; set; }
    }
}
