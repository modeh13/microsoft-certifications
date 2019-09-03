namespace ACM.BL
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }        

        public bool Validate()
        {
            return true;
        }  
    }
}