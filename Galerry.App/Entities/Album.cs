using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Galerry.App.Entities.Base;

namespace Galerry.App.Entities
{
    public class Album : IBaseModel
    {
        [Display(Name = "asd")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zadejte prosím číslo")]
        public int test { get; set; }
    }
}
