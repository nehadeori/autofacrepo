using App.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Model.Entity;
using System.Data.Entity;
namespace Autofac.Model.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private Facultycontext dataContext;
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        protected Facultycontext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        public void Commit()
        {
            DataContext.Commit();
        }
    }
}
