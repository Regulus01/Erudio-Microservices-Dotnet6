using RestWithASPNetUdemy.Model;

namespace RestWithASPNetUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < persons.Count; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindByID(long id)
        {
            return new Person
            {
                id = IncrementAndGet(),
                firstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }


        private Person MockPerson(int i)
        {
            return new Person
            {
                id = IncrementAndGet(),
                firstName = "Person Name " + i,
                LastName = "Person LastName " + i,
                Address = "Some Address " + i,
                Gender = i % 2 == 0 ? "Male" : "Female"
            };
        }

        private long IncrementAndGet()
        {
        
            return Interlocked.Increment(ref count);
        }
    }
}