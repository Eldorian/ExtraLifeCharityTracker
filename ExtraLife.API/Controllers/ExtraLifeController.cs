using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ExtraLife.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtraLife.API.Controllers
{
    [Route("api/[controller]")]
    public class ExtraLifeController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int participantId)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = 
                await client.GetAsync(
                    $"https://www.extra-life.org/index.cfm?fuseaction=donorDrive.participant&participantID={participantId}&format=json");

            response.EnsureSuccessStatusCode();

             var participant = response.Content.ReadAsJsonAsync<ParticipantModel>();
            return Ok(participant);
        }
    }
}