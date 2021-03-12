using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestTask.ViewModels;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
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
    }
}
