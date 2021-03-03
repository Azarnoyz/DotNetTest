using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.ViewModels
{
    public class PromoCodesViewModel
    {

        [Required]
        public List<int> Promo { get; set; }

        public List<int> promoCodes = new List<int>() { 111, 222, 333, 444 };

        public List<int> getPromoCodes()
        {
            return promoCodes;
        }
    }
}
