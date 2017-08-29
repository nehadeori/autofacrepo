using Autofac.Model.Infrastructure;
using Autofac.Model.Repository;
using Autofac.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Model.Entity;

namespace Autofac.Service
{

    public class FacultyService : IFacultyService
    {
        private readonly IFacultyRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public FacultyService(IFacultyRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Faculty> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }
    }

    public interface IFacultyService
    {
        IEnumerable<Faculty> GetAllCustomers();
    }
}
    

