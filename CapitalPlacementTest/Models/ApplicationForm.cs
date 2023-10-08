using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class ApplicationForm : Entity
    {
        public string ImageUrl { get; set; }
        public virtual ICollection<ApplicationFormQuestion> Questions { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public Guid ProgramDetailsId { get; set; }
        [ForeignKey(nameof(ProgramDetailsId))]
        public virtual ProgramDetail ProgramDetails { get; set; }
    }
}
