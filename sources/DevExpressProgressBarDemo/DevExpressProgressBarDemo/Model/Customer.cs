using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressProgressBarDemo.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Visits { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsCool { get; set; }

        public static List<Customer> GetCustomers()
        {
            List<Customer> people = new List<Customer>();
            people.Add(new Customer {Name = "Karen Evans", Birthday = DateTime.Now, City = "Arad", IsCool = false, Visits = 5});
            people.Add(new Customer {Name = "Olivia	Yates", Birthday = DateTime.Now, City = "Timisoara", IsCool = false, Visits = 5});
            people.Add(new Customer {Name = "Cameron Tran", Birthday = DateTime.Now, City = "Oradea", IsCool = true, Visits = 5});
            people.Add(new Customer {Name = "Darnell Pittman", Birthday = DateTime.Now, City = "Vaslui", IsCool = false, Visits = 5});
            people.Add(new Customer {Name = "Gertrude Fields", Birthday = DateTime.Now, City = "Botosani", IsCool = true, Visits = 5});
            people.Add(new Customer {Name = "Andrew Schneider", Birthday = DateTime.Now, City = "Suceava", IsCool = false, Visits = 5});
            people.Add(new Customer {Name = "Audrey West", Birthday = DateTime.Now, City = "Cluj", IsCool = true, Visits = 5});
            people.Add(new Customer {Name = "Angie Morrison", Birthday = DateTime.Now, City = "Iasi", IsCool = true, Visits = 5});
            people.Add(new Customer {Name = "Matt Luna", Birthday = DateTime.Now, City = "Bucuresti", IsCool = true, Visits = 5});
            people.Add(new Customer {Name = "Donnie Schwartz", Birthday = DateTime.Now, City = "Craiova", IsCool = false, Visits = 5});

            return people;
        }
    }
}
