using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonRepository;

namespace PersonRepositoryCaching
{
    public class CachingRepository : IPersonRepository
    {
        private TimeSpan _cacheDuration = new TimeSpan(0, 0, 30);
        private DateTime _dataDateTime;
        private IEnumerable<Person> _cacheItems;

        private IPersonRepository _wrappedRepository;

        private bool IsCacheValid
        {
            get
            {
                var _cacheAge = DateTime.Now - _dataDateTime;
                return _cacheAge < _cacheDuration;
            }
        }

        private void ValidateCache()
        {
            if (_cacheItems == null || !IsCacheValid)
            {
                try
                {
                    _cacheItems = _wrappedRepository.Get();
                    _dataDateTime = DateTime.Now;
                }
                catch
                {
                    _cacheItems = new List<Person>
                    {
                        new Person { GivenName = "No Data Available" }
                    };
                }
            }
        }

        private void InvalidateCache()
        {
            _dataDateTime = DateTime.MinValue;
        }

        public CachingRepository(IPersonRepository wrappedPersonRepository)
        {
            _wrappedRepository = wrappedPersonRepository;
        }

        public Person Get(int id)
        {
            ValidateCache();
            return _cacheItems.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Person> Get()
        {
            ValidateCache();
            return _cacheItems;
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