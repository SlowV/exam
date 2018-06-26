namespace Exam.entity
{
    public class Product
    {
        private string productID;
        private string productName;
        private string price;

        public Product()
        {
        }

        public Product(string productId, string productName, string price)
        {
            productID = productId;
            this.productName = productName;
            this.price = price;
        }

        public string ProductId
        {
            get => productID;
            set => productID = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string Price
        {
            get => price;
            set => price = value;
        }
    }
}