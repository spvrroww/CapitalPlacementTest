using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class VideoInterviewOptions : Entity
    {
        public string Question { get; set; }
        public string AdditionalInformation { get; set; }
        public double MaxDuration { get; set; }
        public string MaxDurationUnit { get; set; }
        public string DeadlineInDays { get; set; }
    }
}
