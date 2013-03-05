using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Model
{
    /// <summary>
    /// 区域，如水东、桥北
    /// </summary>
    public class Region
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public string Name { get; set; }
    }
}
