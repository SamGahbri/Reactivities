using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController(AppDbContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() // GET: api/activities 
        {
            return await context.Activities.ToListAsync(); // Retrieve all activities from the database and return them as a list
        }

        [HttpGet("{id}")] // GET: api/activities/{id}
        public async Task<ActionResult<Activity>> GetActivityDetail(string id) // Retrieve a specific activity by its ID
        {
            var activity = await context.Activities.FindAsync(id); // Find the activity in the database using the provided ID

            if (activity == null) return NotFound(); // If the activity is not found, return a 404 Not Found response

            return activity; // If the activity is found, return it
        }
    }

}
