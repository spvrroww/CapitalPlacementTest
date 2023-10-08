using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.DTOModels
{
    public class ProgramDetailDTO : EntityDTO
    {
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        [Required]
        public string Description { get; set; }
        public string SkillsRequired { get; set; }
        public string Benefits { get; set; }
        public string ApplicationCriteria { get; set; }
        [Required]
        public string ProgramType { get; set; }
        [Required]
        public DateTime ProgramStart { get; set; }
        [Required]
        public DateTime ApplicationOpen { get; set; }
        [Required]
        public DateTime ApplicationClose { get; set; }
        public int Duration { get; set; }
        [Required]
        public string Location { get; set; }
        public int MinQualification { get; set; }
        public int MaxQalifications { get; set; }

    }
}
