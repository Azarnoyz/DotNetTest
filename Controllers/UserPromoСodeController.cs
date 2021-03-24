using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.API.ViewModels.PromoCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.ViewModels;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPromoСodeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromBody] AddPromoCodeViewModel addPromoCodeViewModel)
        {
            try
            {
                return Ok(new { status = true, message = addPromoCodeViewModel });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdatePromoCodeViewModel updatePromoCodeViewModel)
        {
            try
            {
                return Ok(new { status = true, message = "Updated" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete]
        [Route("{promoCodeId}")]
        public IActionResult Delete(Guid promocodeId)
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
