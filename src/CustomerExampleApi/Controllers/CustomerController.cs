using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CustomerExampleApi.DataObjects;
using System.Linq;

namespace CustomerExampleApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private IEnumerable<Customer> _customers;

        public CustomerController()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer(1, new DateTime(1940, 01, 05), "Tim", "Delgado"));
            customers.Add(new Customer(2, new DateTime(1950, 02, 10), "Shane", "Gibbons"));
            customers.Add(new Customer(3, new DateTime(1960, 03, 15), "Mike", "Pennington"));
            customers.Add(new Customer(4, new DateTime(1970, 04, 20), "John", "Boldt"));
            customers.Add(new Customer(4, new DateTime(1980, 05, 25), "Divyash", "Patel"));
            _customers = customers;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customers.Where(x => (x.Id == id)).Single();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
