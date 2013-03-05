using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        public string Profession { get; set; }
        public string ParentName { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string District { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
        public DateTime FirstVisit { get; set; }
        public DateTime LastVisit { get; set; }
    }
}
