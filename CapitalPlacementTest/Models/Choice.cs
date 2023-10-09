using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class Choice : Entity
    {
        public Guid ApplicationFormQuestionId { get; set; }
        public string ChoiceValue { get; set; }
        [ForeignKey(nameof(ApplicationFormQuestionId))]
        public virtual ApplicationFormQuestion ApplicationFormQuestion { get; set; }
    }
}
