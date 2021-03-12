using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.API.ViewModels.Preferencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.ViewModels;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPreferenciesController : ControllerBase
    {
        [HttpPost]
        [Route("{userId}")]
        public IActionResult Add(Guid userId, [FromBody] AddPreferenceViewModel preferenceViewModel)
        {
            try
            {
                return Ok(new { status = true, message = preferenceViewModel });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{userId}")]
        public IActionResult Get()
        {
            return Ok(new PreferencesViewModel().getPreferences());
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdatePreferenceViewModel updatePreferenceViewModel)
        {
            try
            {
                return Ok(new { status = true, message = "Edited" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete]
        [Route("{userId}/{preferenceId}")]
        public IActionResult Delete(Guid userId, Guid preferenceId)
        {
            try
            {
                return Ok(new { status = true, message = "Deleted" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
