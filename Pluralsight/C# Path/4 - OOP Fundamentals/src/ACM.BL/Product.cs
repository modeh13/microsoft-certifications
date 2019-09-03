using ACM.Common;

namespace ACM.BL
{
    public sealed class Product : EntityBase, ILoggable
    {
        public int ProductId { get; set; }

        private string _productName;
        public string ProductName 
        { 
            get 
            {   
                return _productName.InsertSpaces();
            }   
            set { _productName = value; } 
        }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }        
        
        public override string ToString() => ProductName;

        public override bool Validate()
        {
            return true;
        }

        public string Log() =>  $"{ProductId}: {ProductName}, Status: {EntityState.ToString()}";
    }
}