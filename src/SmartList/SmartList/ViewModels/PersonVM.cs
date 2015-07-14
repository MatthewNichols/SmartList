using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.Models;

namespace SmartList.ViewModels
{
    public class PersonVM
    {

        public PersonVM(Person person)
        {
            FullName = $"{person.FirstName} {person.LastName}";
            Email = person.Email;
            Phone = person.Phone;
            Age = ComputeAge(person.Birthday);
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        private int ComputeAge(DateTime birthday)
        {
            var today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if (birthday > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }


        public static Person GetPerson()
        {
            return new Person
            {
                FirstName = "Matthew",
                LastName = "Nichols",
                Email = "blah@blah.com",
                Phone = "303 867-5309",
                Birthday = DateTime.Today.Subtract(TimeSpan.FromDays(30*365)),
                Id = 123
            };
        }
        
    }
}
