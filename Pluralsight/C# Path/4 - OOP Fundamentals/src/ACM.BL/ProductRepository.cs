using System.Collections.Generic;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int productId)
        {
            return new Product();            
        }

        public List<Product> Retrive()
        {
            return new List<Product>();
        } 

        public bool Save(Product entity)
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