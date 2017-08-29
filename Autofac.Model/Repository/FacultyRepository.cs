using Autofac.Model.Entity;
using Autofac.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Model.Infrastructure;
using App.Data.Infrastructure;

namespace Autofac.Model.Repository
{
    public class FacultyRepository : RepositoryBase<Faculty>, IFacultyRepository
    {
        public FacultyRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface IFacultyRepository : IRepository<Faculty>
    {

    }
}
