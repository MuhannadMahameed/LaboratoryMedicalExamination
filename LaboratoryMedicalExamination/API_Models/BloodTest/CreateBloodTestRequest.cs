using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.API_Models.BloodTest
{
    public record CreateBloodTestRequest
    {
        public int PatientID { get; init; }
        public DateTime TestDate { get; init; }
        public string TestType { get; init; }
        public string TestResults { get; init; }
        public string Comments { get; init; }
    }
}
