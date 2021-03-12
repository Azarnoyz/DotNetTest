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
        [HttpDelete]
        public void DeleteProfile([FromForm] DeleteProfileViewModel deleteProfileViewModel) { }

        [HttpPatch]
        public void ChangeCredentials([FromBody] DeleteProfileViewModel deleteProfileViewModel) { }

        [HttpPut("change-photo")]
        public ActionResult ChangePhoto(Guid userId, IFormFile file)
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
