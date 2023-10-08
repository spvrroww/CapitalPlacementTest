using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class Education : Entity
    {
        public string School { get; set; }
        public string Degree { get; set; }
        public string CourseName { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrentPlaceOfStudy { get; set; }
        public Guid ApplicationFormId { get; set; }
        [ForeignKey(nameof(ApplicationFormId))]
        public ApplicationForm ApplicationForm { get; set; }
    }
}
