using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class Activity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public required string PatientName { get; set; } //user (required) to make fields nullable

        public required string TreatmentName { get; set; } 

        public DateTime TreatmentDate { get; set; }

        public required string TreatmentDescription { get; set; }

        public required string TreatmentCategory { get; set; }

        public bool IsApproved { get; set; }


        //locations props

        public required string City { get; set; }

        public required string DenturePractice { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
