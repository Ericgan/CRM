using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Model
{
    /// <summary>
    /// 服务类别，如教育培训、电脑维修、心理咨询等
    /// </summary>
    public class ServiceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
