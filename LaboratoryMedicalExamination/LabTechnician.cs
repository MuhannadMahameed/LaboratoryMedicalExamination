using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination
{
    public class LabTechnician
    {
        [Key]
        public int LabTechnicianID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Specialty { get; set; }

        public string ContactInformation { get; set; }

        public ICollection<BloodTest> BloodTests { get; set; }
    }


}
