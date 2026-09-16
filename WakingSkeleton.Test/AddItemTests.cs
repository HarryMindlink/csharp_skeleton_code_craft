namespace WakingSkeleton.Test;

using GuitarShack;

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