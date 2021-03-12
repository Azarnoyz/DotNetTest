﻿using Microsoft.AspNetCore.Http;
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
    public class UserPromocodeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromBody] AddPromoCodeViewModel promoCodeViewModel)
        {
            try
            {
                return Ok(new { status = true, message = promoCodeViewModel });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut]
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

        [HttpDelete]

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
