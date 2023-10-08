using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.DTOModels
{
    public class ApplicationFormQuestionDTO : EntityDTO
    {
        public string QuestionType { get; set; }
        public string QuestionTitle { get; set; }
        public Guid ApplicationFormId { get; set; }
        public bool IsMandatory { get; set; } = false;
        public bool IsInternal { get; set; } = false;
    }
}
