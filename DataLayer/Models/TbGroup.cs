using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class TbGroup
    {
        public TbGroup()
        {
            this.TbGroups1 = new List<TbGroup>();
            this.TbProducts = new List<TbProduct>();
        }

        public long ID { get; set; }
        public string Title { get; set; }
        public string Des { get; set; }
        public long Parent_id { get; set; }
        public virtual ICollection<TbGroup> TbGroups1 { get; set; }
        public virtual TbGroup TbGroup1 { get; set; }
        public virtual ICollection<TbProduct> TbProducts { get; set; }
    }
}
