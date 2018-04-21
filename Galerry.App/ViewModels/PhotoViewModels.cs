using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Galerry.App.ViewModels
{
    public class PhotoViewModel
    {
        [Display(Name = "Datum a čas pořízení")]
        public DateTime Date { get; set; }
        public string Format { get; set; }
        [Display(Name = "Název")]
        public string Name { get; set; }
        public string Resolution { get; set; }
        [Display(Name = "Poznámka")]
        public string Note { get; set; }
    }
}
