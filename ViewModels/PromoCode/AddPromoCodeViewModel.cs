﻿using System;
using System.ComponentModel.DataAnnotations;


namespace Store.API.ViewModels.PromoCode
{
    public class AddPromoCodeViewModel
    {
        [Required]
        public Guid PromoCodeId { get; set; }

        [Required]
        public string PromoCodeName { get; set; }
    }
}
