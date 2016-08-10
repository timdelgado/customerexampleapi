using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerExampleApi.DataObjects
{
    public class Customer
    {
        public Customer(int id, DateTime dateOfBirth, string firstName, string lastName)
        {
            this.Id = id;
            this.DateOfBirth = dateOfBirth;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        public int Age
        {
            get { return ((DateTime.Now - DateOfBirth).Days)/365 ; }
        }
    }
}
