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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public DateTime DatOfBirth { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<ApplicationFormQuestion> Questions { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public Guid ProgramDetailsId { get; set; }
        [ForeignKey(nameof(ProgramDetailsId))]
        public ProgramDetail ProgramDetails { get; set; }
    }
}
