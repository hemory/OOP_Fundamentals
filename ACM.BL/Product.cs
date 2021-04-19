using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata;
using ACM.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public int ProductId { get; private set; }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        private string _productName;

        public string ProductName
        {
            get => _productName.InsertSpaces(); //uses the extension method
            set => _productName = value;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public override bool Validate()
        {
            bool isValid = !string.IsNullOrWhiteSpace(ProductName);

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public string Log() =>
            $"{ProductId}: {_productName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
    }
}