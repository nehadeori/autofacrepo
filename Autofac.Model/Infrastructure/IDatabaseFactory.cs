using Autofac.Model;
using System;
namespace App.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Facultycontext Get();
    }
}
