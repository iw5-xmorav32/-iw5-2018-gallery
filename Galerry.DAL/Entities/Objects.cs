using System;
using Galerry.DAL.Entities.Base;

namespace Galerry.DAL.Entities
{
    public class Objects : IBaseModel
    {
        public string Name { get; set; }
        public int PositionOnPhotos { get; set; }
        public Guid IdOfPhotos { get; set; }
    }
}
