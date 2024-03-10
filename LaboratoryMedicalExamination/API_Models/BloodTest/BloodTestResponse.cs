using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.API_Models.BloodTest
{
    public record BloodTestResponse
    {
        public int BloodTestID { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public List<BloodParameter.BloodParamResponse> BloodParameters { get; init; }
    }
}
