using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace Repository
{
    class Facultycontext:DbContext
    {
       
        
            public Facultycontext() : base("name=MyConnectionString")
            {

            }
            public DbSet<Faculty> faculties { get; set; }
          
        }
    }

