using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Model
{
    /// <summary>
    /// 调查问卷
    /// </summary>
    public class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 受众
        /// </summary>
        public string AudienceType { get; set; }
        public string ServiceCategory { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
