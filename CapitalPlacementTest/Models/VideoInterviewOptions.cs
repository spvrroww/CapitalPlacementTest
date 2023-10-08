using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class VideoInterviewOption : Entity
    {
        public string Question { get; set; }
        public string AdditionalInformation { get; set; }
        public double MaxDuration { get; set; }
        public string MaxDurationUnit { get; set; }
        public string DeadlineInDays { get; set; }
        public Guid StageId { get; set; }
        [ForeignKey(nameof(StageId))]
        public Stage Stage { get; set; }
    }
}
