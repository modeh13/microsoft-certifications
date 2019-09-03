using System.Collections.Generic;
using ACM.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerType { get; set; }
        public string FullName 
        { 
            get 
            {
                string _fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(_fullName))
                    {
                        _fullName += ", " + FirstName;
                    }
                }

                return _fullName;
            }
        }

        public string EmailAddress { get; set; }
        
        // Composition relationship (has a) 1-1, 1-N, N-N
        public List<Address> AddressList { get; set; }        

        public Customer() : this(0)
        {               
        }

        public Customer(int customerId)
        {            
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public override string ToString() => FullName;

        public override bool Validate()
        {
            return true;
        }

        public string Log() =>  $"{CustomerId}: {FullName}, Email: {EmailAddress}, Status: {EntityState.ToString()}";
    }
}