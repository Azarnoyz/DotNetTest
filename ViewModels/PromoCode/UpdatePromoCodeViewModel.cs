using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.ViewModels.PromoCode
{
    public class UpdatePromoCodeViewModel
    {
        [Required]
        public Guid PromoCodeId { get; set; }

        [Required]
        public string PromoCode { get; set; }
    }
}
