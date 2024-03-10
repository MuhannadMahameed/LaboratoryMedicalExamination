using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMedicalExamination.API_Models.Patient
{
    public record UpsertPatientRequest
    {
        public string Name { get; init; }
        public DateTime Birth { get; init; }

        public string Description { get; init; }

        public string Gender { get; init; }


    }
}
