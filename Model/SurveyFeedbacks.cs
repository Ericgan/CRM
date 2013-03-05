using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Model
{
    public class SurveyFeedbacks
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string AudienceName { get; set; }
        public int AudienceAge { get; set; }
        public string AudienceGender { get; set; }
        public string AudienceProfession { get; set; }
        public string Feedbacks { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
