using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerDataAccess;

namespace Web_API_Application.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<Customer> Get()
        {
            using (NorthwindDBEntities objNorthwindDBEntities = new NorthwindDBEntities())
            {
                return objNorthwindDBEntities.Customers.ToList();
            }                
        }
        public Customer Get(string id)
        {
            using (NorthwindDBEntities objNorthwindDBEntities = new NorthwindDBEntities())
            {
                return objNorthwindDBEntities.Customers.FirstOrDefault(c => c.CustomerID == id);
            }
        }
    }
}
