using System.Collections.Generic;

namespace PersonRepository
{
    public interface IPersonRepository
    {
        Person Get(int id);

        IEnumerable<Person> Get();

        void Add(Person person);

        void Delete(int id);
    }
}