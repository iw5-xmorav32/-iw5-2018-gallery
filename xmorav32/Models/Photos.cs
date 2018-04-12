using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using xmorav32.Models.Base;

namespace xmorav32.Models
{
    public class Photos : IBaseModel
    {
        [Display(Name = "Datum a čas pořízení")]
        public DateTime Date { get; set; }
        public string Format { get; set; }
        [Display(Name = "Název")]
        public string Name { get; set; }
        public string Resolution { get; set; }
        [Display(Name = "Poznámka")]
        public string Note { get; set; }
        public Guid IdOfAlbum { get; set; }
    }
}
