using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Galerry.DAL.Entities.Base;

namespace Galerry.DAL.Entities
{
    public class Album : IBaseModel
    {
        [Display(Name = "asd")]
        public string Name { get; set; }
    }
}
