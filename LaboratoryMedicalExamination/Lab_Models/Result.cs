using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.Lab_Models
{
    public class Result
    {
        [Key]
        public int ResultID { get; set; }

        [Required]
        public int TestID { get; set; }

        [Required]
        public string Interpretation { get; set; } = null!;

        public string? RecommendedActions { get; set; }

        [ForeignKey("TestID")]
        public BloodTest BloodTest { get; set; } = null!;
    }
}
