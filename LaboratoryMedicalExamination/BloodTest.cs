using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination
{
    public class BloodTest
    {
        [Key]
        public int TestID { get; set; }

        [Required]
        public int PatientID { get; set; }

        [Required]
        public DateTime TestDate { get; set; }

        [Required]
        public string TestType { get; set; }

        [Required]
        public string TestResults { get; set; }

        public string Comments { get; set; }

        [ForeignKey("PatientID")]
        public Patient Patient { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
