namespace fed.cloud.communication.Shopper
{
    public class ShoppingCheckoutResult
    {
        public ShoppingCheckoutResult()
        {
            ShoppingId = -1;
        }

        public int ShoppingId { get; set; }

        public int TotalLines { get; set; }

        public string Name { get; set; }
    }
}