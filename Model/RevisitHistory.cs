using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Model
{
    /// <summary>
    /// 回访记录
    /// </summary>
    public class RevisitHistory
    {
        public int Id { get; set; }
        public RevisitType Type { get; set; }
        public int CustomerId { get; set; }
        public int OperatorId { get; set; }
        public DateTime RevisitTime { get; set; }
        public string Feedbacks { get; set; }
    }
}
