using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.ViewModels
{
    [Obsolete]
    public class PreferencesViewModel
    {
        public List<Preferences> preferences = new List<Preferences>();

        public List<Preferences> getPreferences()
        {

            preferences.Add(new Preferences() { Id = 0, ProductName = "phone" });
            preferences.Add(new Preferences() { Id = 1, ProductName = "keyboard" });
            preferences.Add(new Preferences() { Id = 2, ProductName = "mouse" });

            return preferences;
        }
    }

    public class Preferences
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }

    }

   
}
