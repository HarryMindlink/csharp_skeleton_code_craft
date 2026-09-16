namespace WakingSkeleton.Test;

[TestFixture]
internal class AddItemTests
{
    [Test]
    public void AddItemWithSufficientStockToOrder()
    {
        int productId = 327;

        Order order = new Order();

        order.AddItem(productId);

        int productQuantity = order.GetProductQuantity(productId);

        Assert.That(productQuantity, Is.EqualTo(1));
    }
}

internal class Order
{
    public int GetProductQuantity(int productId)
    {
        return 1;
    }

    public void AddItem(int productId)
    {
    }
}
