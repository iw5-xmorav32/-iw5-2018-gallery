using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Galerry.App.ViewModels
{
    public class AlbumViewModel
    {

        [Display(Name = "Jmnéno")]
        public string Name { get; set; }
        public Guid Id { get; set; }

        public int create()
        {

            return 1;
        }
    }
}
