using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Questions
    {
        public int QuestionId { get; set; }
        public int ReportItemId { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }
        public DateTime QstnLastUpdatedDate { get; set; }
        public string QstnLastUpdatedBy { get; set; }
        public DateTime? RespLastUpdatedDate { get; set; }
        public string RespLastUpdatedBy { get; set; }

        public ReportItem ReportItem { get; set; }
    }
}
