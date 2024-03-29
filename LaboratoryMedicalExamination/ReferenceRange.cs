﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination
{
    public  class ReferenceRange
    {
        [Key]
        public int RangeID { get; set; }

        [Required]
        public int ParameterID { get; set; }

        public string AgeRange { get; set; }

        public string Gender { get; set; }

        [Required]
        public double LowerLimit { get; set; }

        [Required]
        public double UpperLimit { get; set; }

        [ForeignKey("ParameterID")]
        public BloodParameter BloodParameter { get; set; }
    }
}
