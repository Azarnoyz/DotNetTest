using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.ViewModels.Preferencies
{
    public class UpdatePreferenceViewModel
    {
        [Required]
        public Guid ProductId { get; set; }
        
        [Required]
        public string ProductName { get; set; }
    }
}
