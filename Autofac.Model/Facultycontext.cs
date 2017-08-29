using Autofac.Model;
using Autofac.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Model
{
   public class Facultycontext : DbContext
    {


        public Facultycontext() : base("name=MyConnectionString")
        {

        }
        public DbSet <Faculty> faculties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
