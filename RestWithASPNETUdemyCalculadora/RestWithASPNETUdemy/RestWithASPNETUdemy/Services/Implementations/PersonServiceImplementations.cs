using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementations : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            // not implemented
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MoackPerson(i);
                persons.Add(person);
            }
            return persons;

        }


        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Marcelo",
                LastName = "Cardoso",
                Adress = "Rua número do abraço , nro 5 - SP",
                Gender = "masculino"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MoackPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastNmae" + i,
                Adress = "Some Adress" + i,
                Gender = GerarGenero(i)
            };
        }

        private string GerarGenero(int i)
        {
            if (i % 2 == 0)
            {
                return "Masculino";
            }
            return "Feminino";
        }

        private long IncrementAndGet()
        {

            return Interlocked.Increment(ref count);
        }
    }
}
