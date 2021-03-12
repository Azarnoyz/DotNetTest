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
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("signup")]
        public void SignUp([FromForm] SignUpViewModel signUpViewModel) { }

        [HttpPost("delete/profile")]
        public void DeleteProfile([FromForm] DeleteProfileViewModel deleteProfileViewModel) { }

        [HttpPost("change/credentials")]
        public void ChangeCredentials([FromBody] DeleteProfileViewModel deleteProfileViewModel) { }

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

        [HttpPost("add/promo")]
        public IActionResult addPromoCodes([FromBody] PromoCodesViewModel promoCodesViewModel)
        {
            try
            {
                return Ok(new { status = true, message = promoCodesViewModel });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("change/promo")]
        public IActionResult changePromoCodes([FromBody] PromoCodesViewModel promoCodesViewModel)
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
        public IActionResult deletePromoCodes([FromBody] PromoCodesViewModel promoCodesViewModel)
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
