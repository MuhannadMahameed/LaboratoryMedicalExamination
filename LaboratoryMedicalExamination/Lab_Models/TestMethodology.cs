using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.Lab_Models
{
    public class TestMethodology
    {
        [Key]
        public int MethodologyID { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
