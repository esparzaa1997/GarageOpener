using GarageOpener.GarageData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace GarageOpener.Controllers
{
    [ApiController]
    public class GarageController : ControllerBase
    {
        private IGarageData _garageData;
        public GarageController(IGarageData garageData)
        { 
            _garageData = garageData;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetGarage(long id)
        {
            var garage = _garageData.GetGarage(id);

            if(garage == null)
            {
                return NotFound($"Employee with Id: {id} was not found");
            }
            else
            {
                return Ok(garage);
            };
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetGarages()
        {
            return Ok(_garageData.GetGarages());
        }


    }
}
