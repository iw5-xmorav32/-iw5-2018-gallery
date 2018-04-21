using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galerry.App.Entities.Base;

namespace Galerry.App.Entities
{
    public class Objects : IBaseModel
    {
        public string Name { get; set; }
        public int PositionOnPhotos { get; set; }
        public Guid IdOfPhotos { get; set; }
    }
}
