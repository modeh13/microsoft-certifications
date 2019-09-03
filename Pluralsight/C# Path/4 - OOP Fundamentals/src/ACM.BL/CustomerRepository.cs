using System.Collections.Generic;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // Collaborating Relationship between Classes (uses a)
        private AddressRepository _addressRepository;

        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        public Customer Retrive(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrive()
        {
            return new List<Customer>();
        }

        public bool Save(Customer entity)
        {
            var success = entity.IsValid;

            if(entity.IsValid && entity.HasChanges)
            {
                if(entity.IsValid)
                {
                    // Call an insert stored procedure
                }
                else 
                {
                    // Call an update stored procedure
                }
            }

            return success;
        }
    }
}