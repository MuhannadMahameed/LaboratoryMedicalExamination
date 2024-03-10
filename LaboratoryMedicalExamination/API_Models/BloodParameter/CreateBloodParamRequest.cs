using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.API_Models.BloodParameter
{
    public record CreateBloodParamRequest
    {
        public string Name { get; init; }
        public string UnitOfMeasurement { get; init; }
        public string Description { get; init; }
    }
}
