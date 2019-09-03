using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrive(int addressId)
        {
            return new Address();
        }

        public IEnumerable<Address> RetriveByCustomerId(int customerId)
        {
            return new List<Address>();
        }

        public bool Save(Address entity)
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