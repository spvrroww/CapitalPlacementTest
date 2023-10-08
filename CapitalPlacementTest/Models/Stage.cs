using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class Stage : Entity
    {
        public string Name { get; set; }
        public string StageType { get; set; }
        public bool IsVisible { get; set; }
        public Guid ProgramDetailId { get; set; }
        [ForeignKey(nameof(ProgramDetailId))]
        public ProgramDetail ProgramDetail { get; set; }
        public virtual VideoInterviewOption VideoInterviewOptions { get; set; }
    }
}
