using System;
using Galerry.DAL.Entities;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity;


namespace Galerry.DAL
{
    public class DataContext : DbContext
    {

        public DbSet<Album> Albums { get; set; }
        public DbSet<Objects> Object { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Photos> Photo { get; set; }

        public DataContext()
           : base("DataContext")
        { }
    }
}
