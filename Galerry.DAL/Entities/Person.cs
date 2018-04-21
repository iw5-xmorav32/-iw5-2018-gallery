using System;
using Galerry.DAL.Entities.Base;

namespace Galerry.DAL.Entities
{
    public class Person : IBaseModel
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int PositionOnPhotos { get; set; }
        public Guid IdOfPhotos { get; set; }
    }
}
