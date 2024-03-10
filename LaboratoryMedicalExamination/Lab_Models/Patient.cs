using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.Lab_Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime Birth { get; set; }

        [Required]
        public string Gender { get; set; } = null!;

        public string? ContactInformation { get; set; }

        public ICollection<BloodTest>? BloodTests { get; set; } 
    }
}
