using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class TbUnit
    {
        public TbUnit()
        {
            this.TbProducts = new List<TbProduct>();
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Des { get; set; }
        public virtual ICollection<TbProduct> TbProducts { get; set; }
    }
}
