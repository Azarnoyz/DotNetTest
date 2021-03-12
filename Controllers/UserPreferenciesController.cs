using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpPost("add/preferences")]
        public IActionResult AddPreferences([FromBody] List<Preferences> preferencesViewModel)
        {

            try
            {
                return Ok(new { status = true, message = preferencesViewModel });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("get/preferences")]
        public List<Preferences> GetPreferences()
        {
            return new PreferencesViewModel().getPreferences();
        }

        [HttpPost("change/preferences")]
        public IActionResult EditPreferences([FromBody] List<Preferences> editedPreferencesViewModel)
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

        [HttpPost("delete/preferences")]
        public IActionResult DeletePreferences([FromBody] List<Preferences> needToDeletePreferencesViewModel)
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
