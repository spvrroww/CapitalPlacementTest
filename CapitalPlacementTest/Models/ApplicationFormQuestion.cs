using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class ApplicationFormQuestion : Entity
    {
        public string QuestionType { get; set; }
        public string QuestionTitle { get; set; }
        public Guid ApplicationFormId { get; set; }
        public bool IsMandatory { get; set; } = false;
        public bool IsInternal { get; set; } = false;
        [ForeignKey(nameof(ApplicationFormId))]
        public virtual ApplicationForm ApplicationForm { get; set; }
        public ICollection<Choice> Choices { get; set; }
        

    }
}
