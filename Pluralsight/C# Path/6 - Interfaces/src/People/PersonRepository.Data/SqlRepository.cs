using System;
using System.Collections.Generic;

namespace PersonRepository.Data
{
    public class SqlRepository : IPersonRepository
    {
        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Get()
        {
            // There should be an implementation of SQL data source.
            return new List<Person>
            {
                new Person { Id = 1, FamilyName = "Ramirez", GivenName = "Fabio", StartDate = DateTime.Now, Rating = 100  },
                new Person { Id = 1, FamilyName = "Vela", GivenName = "Rosa", StartDate = DateTime.Now, Rating = 100  },
                new Person { Id = 1, FamilyName = "Ramirez", GivenName = "Fabian", StartDate = DateTime.Now, Rating = 90  },
                new Person { Id = 1, FamilyName = "Ramirez", GivenName = "German", StartDate = DateTime.Now, Rating = 80  },
                new Person { Id = 1, FamilyName = "Ramirez", GivenName = "Luisa", StartDate = DateTime.Now, Rating = 70  },
                new Person { Id = 1, FamilyName = "Ramirez", GivenName = "Juan", StartDate = DateTime.Now, Rating = 60  },
                new Person { Id = 1, FamilyName = "Ramirez", GivenName = "Luis", StartDate = DateTime.Now, Rating = 50  }
            };
        }

        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}