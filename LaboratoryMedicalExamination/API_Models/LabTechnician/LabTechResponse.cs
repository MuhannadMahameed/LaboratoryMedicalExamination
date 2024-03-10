using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.API_Models.LabTechnician
{
    public record LabTechResponse
    {
        public int LabTechnicianID { get; init; }
        public string Name { get; init; } = null!;
        public string Specialty { get; init; } = null!;
        public string? ContactInformation { get; init; }
    }
}
