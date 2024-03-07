using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination
{
    public class BloodParameter
    {
        [Key]
        public int ParameterID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UnitOfMeasurement { get; set; }

        public string Description { get; set; }
    }
}
