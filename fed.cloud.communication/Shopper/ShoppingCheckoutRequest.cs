namespace fed.cloud.communication.Shopper
{
    public class ShoppingCheckoutRequest
    {
        public int ShoppingListId { get; set; }

        public bool IsForceCheckout { get; set; }
    }
}