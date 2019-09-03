using System;

namespace ACM.BL
{
    public enum AddressType { Home, Work, Email }

    public class Address : EntityBase
    {
        public string StreetLine { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public AddressType AddressType { get; set; }

        public override bool Validate()
        {
            return true;
        }
    }
}