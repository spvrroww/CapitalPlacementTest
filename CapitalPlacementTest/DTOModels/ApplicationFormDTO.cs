﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTest.DTOModels
{
    public class ApplicationFormDTO : EntityDTO
    {
        public string ImageUrl { get; set; }
        public List<ApplicationFormQuestionDTO> ApplicationFormQuestions { get; set; }
    }
}
