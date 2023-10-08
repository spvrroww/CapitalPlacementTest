using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.Models
{
    public class ProgramDetail : Entity
    {       
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string SkillsRequired { get; set; }
        public string Benefits { get; set; }
        public string ApplicationCriteria { get; set; }
        public string ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public int Duration { get; set; }
        public string Location { get; set; }
        public int MinQualification { get; set; }
        public int MaxQalifications { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
        public virtual ApplicationForm ApplicationForm { get; set; }
    }
}
