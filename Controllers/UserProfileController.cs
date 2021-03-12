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
        [Route("{userId}")]
        public void DeleteProfile(Guid userId, [FromForm] DeleteProfileViewModel deleteProfileViewModel) 
        {
            
        }

        [HttpPatch]
        [Route("{userId}")]
        public void UpdateProfile(Guid userId, [FromBody] UpdateProfileViewModel updateProfileViewModel) 
        {
        
        }

        [HttpPut("{userId}/change-photo")]
        public ActionResult UpdateProfilePhoto(Guid userId, IFormFile file)
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
