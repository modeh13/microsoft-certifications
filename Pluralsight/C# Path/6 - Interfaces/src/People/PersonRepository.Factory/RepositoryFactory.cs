using System;
using PersonRepository.CSV;
using PersonRepository.Data;
using PersonRepository.Service;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(string repositoryType)
        {
            IPersonRepository repository = null;

            switch (repositoryType)
            {
                case "Service":
                    repository = new ServiceRepository();
                    break;
                case "CSV":
                    repository = new CSVRepository();
                    break;

                case "SQL":
                    repository = new SqlRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type.");
            }

            return repository;
        }
    }
}