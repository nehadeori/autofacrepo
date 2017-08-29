using Autofac.Model;
using Autofac.Model.Infrastructure;

namespace App.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Facultycontext dataContext;
        public Facultycontext Get()
        {
            return dataContext ?? (dataContext = new Facultycontext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
