using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestTask.ViewModels;

namespace TestTask.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost("registration")]
       public void Registration([FromForm]RegistrationViewModel registration) { }

        [HttpPost("delete/profile")]
        public void DeleteProfile([FromForm] DeleteProfileViewModel deleteProfile) { }

        [HttpPost("change/credentials")]
        public void ChangeCredentials([FromBody] DeleteProfileViewModel deleteProfile) { }

        [HttpPost("change/photo")]
        public ActionResult ChangePhoto(IFormFile file)
        {
            
            var image = file;
            
            if (image.Length > 0)
            {
                using (var fileStream = new FileStream(image.FileName, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
            }
            return Ok(new { status = true, message = "Photo updated successfully" });
        }

        [HttpPost("add/preferences")]
        public IActionResult AddPreferences([FromBody] List<Preferences> preferences)
        {

            try
            {
                return Ok(new { status = true, message = preferences });
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
        public IActionResult EditPreferences([FromBody] List<Preferences> editedPreferences)
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
        public IActionResult DeletePreferences([FromBody] List<Preferences> needToDeletePreferences)
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

        [HttpPost("add/promo")]
        public IActionResult addPromoCodes([FromBody] PromoCodesViewModel promoCodes)
        {
            try
            {
                return Ok(new { status = true, message = promoCodes });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("change/promo")]
        public IActionResult changePromoCodes([FromBody] PromoCodesViewModel promoCodes)
        {
            try
            {
                return Ok(new { status = true, message = "CHanged" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("delete/promo")]
        public IActionResult deletePromoCodes([FromBody] PromoCodesViewModel promoCodes)
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
