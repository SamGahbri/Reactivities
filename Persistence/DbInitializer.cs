//using System;
//using Domain;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;
using System;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext Context)
    {
        if (Context.Activities.Any()) return;

        // Add TreatmentName property initialization to each Activity object initializer
        var activities = new List<Activity>
        {
            new()
            {
                PatientName = "Past Activity 1",
                TreatmentName = "Initial Consultation",
                TreatmentDate = DateTime.Now.AddMonths(-2),
                TreatmentDescription = "Activity 2 months ago",
                TreatmentCategory = "drinks",
                City = "London",
                DenturePractice = "The Lamb and Flag, 33, Rose Street, Seven Dials, Covent Garden, London, Greater London, England, WC2E 9EB, United Kingdom",
                Latitude = 51.51171665,
                Longitude = -0.1256611057818921,
            },
            new()
            {
                PatientName = "Past Activity 2",
                TreatmentName = "Routine Checkup",
                TreatmentDate = DateTime.Now.AddMonths(-1),
                TreatmentDescription = "Activity 1 month ago",
                TreatmentCategory = "culture",
                City = "Paris",
                DenturePractice = "Louvre Museum, Rue Saint-Honoré, Quartier du Palais Royal, 1st Arrondissement, Paris, Ile-de-France, Metropolitan France, 75001, France",
                Latitude = 48.8611473,
                Longitude = 2.33802768704666
            },
            new() {
                PatientName = "Future Activity 1",
                TreatmentName = "Follow-up",
                TreatmentDate = DateTime.Now.AddMonths(1),
                TreatmentDescription = "Activity 1 month in future",
                TreatmentCategory = "culture",
                City = "London",
                DenturePractice = "Natural History Museum",
                Latitude = 51.496510900000004,
                Longitude = -0.17600190725447445
            },
            new()
            {
                PatientName = "Future Activity 2",
                TreatmentName = "Music Therapy",
                TreatmentDate = DateTime.Now.AddMonths(2),
                TreatmentDescription = "Activity 2 months in future",
                TreatmentCategory = "music",
                City = "London",
                DenturePractice = "The O2",
                Latitude = 51.502936649999995,
                Longitude = 0.0032029278126681844
            },
            new()
            {
                PatientName = "Future Activity 3",
                TreatmentName = "Dental Cleaning",
                TreatmentDate = DateTime.Now.AddMonths(3),
                TreatmentDescription = "Activity 3 months in future",
                TreatmentCategory = "drinks",
                City = "London",
                DenturePractice = "The Mayflower",
                Latitude = 51.501778,
                Longitude = -0.053577
            },
            new()
            {
                PatientName = "Future Activity 4",
                TreatmentName = "Consultation",
                TreatmentDate = DateTime.Now.AddMonths(4),
                TreatmentDescription = "Activity 4 months in future",
                TreatmentCategory = "drinks",
                City = "London",
                DenturePractice = "The Blackfriar",
                Latitude = 51.512146650000005,
                Longitude = -0.10364680647106028
            },
            new()
            {
                PatientName = "Future Activity 5",
                TreatmentName = "Museum Visit",
                TreatmentDate = DateTime.Now.AddMonths(5),
                TreatmentDescription = "Activity 5 months in future",
                TreatmentCategory = "culture",
                City = "London",
                DenturePractice = "Sherlock Holmes Museum, 221b, Baker Street, Marylebone, London, Greater London, England, NW1 6XE, United Kingdom",
                Latitude = 51.5237629,
                Longitude = -0.1584743
            },
            new()
            {
                PatientName = "Future Activity 6",
                TreatmentName = "Music Session",
                TreatmentDate = DateTime.Now.AddMonths(6),
                TreatmentDescription = "Activity 6 months in future",
                TreatmentCategory = "music",
                City = "London",
                DenturePractice = "Roundhouse, Chalk Farm Road, Maitland Park, Chalk Farm, London Borough of Camden, London, Greater London, England, NW1 8EH, United Kingdom",
                Latitude = 51.5432505,
                Longitude = -0.15197608174931165
            },
            new()
            {
                PatientName = "Future Activity 7",
                TreatmentName = "River Tour",
                TreatmentDate = DateTime.Now.AddMonths(7),
                TreatmentDescription = "Activity 2 months ago",
                TreatmentCategory = "travel",
                City = "London",
                DenturePractice = "River Thames, England, United Kingdom",
                Latitude = 51.5575525,
                Longitude = -0.781404
            },
            new()
            {
                PatientName = "Future Activity 8",
                TreatmentName = "Film Screening",
                TreatmentDate = DateTime.Now.AddMonths(8),
                TreatmentDescription = "Activity 8 months in future",
                TreatmentCategory = "film",
                City = "London",
                DenturePractice = "River Thames, England, United Kingdom",
                Latitude = 51.5575525,
                Longitude = -0.781404
            }
        };


    }
}
