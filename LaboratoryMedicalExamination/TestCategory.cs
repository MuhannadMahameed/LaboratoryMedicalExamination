using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination
{
    public class TestCategory 
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
