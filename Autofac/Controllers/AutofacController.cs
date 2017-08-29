using Autofac.Model.Entity;
using Autofac.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace Autofac.Controllers
{
    public class AutofacController : ApiController
    {
        public class CustomerApiController : ApiController
        {
            private readonly IFacultyService facultyService;

            public CustomerApiController(IFacultyService customerService)
            {
                this.facultyService = customerService;
            }

            [HttpGet]
            public IEnumerable<Faculty> Get()
            {
                try
                {
                    return facultyService.GetAllCustomers();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        }
    }
}
