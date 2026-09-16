using Moq;

namespace WakingSkeleton.Test;

using GuitarShack;

[TestFixture]
internal class AddItemTests
{
    [Test]
    public void AddItemWithSufficientStockToOrder()
    {
        const int productId = 327;

        var mockInventory = new Mock<IInventory>();
        mockInventory.Setup(i => i.TryAddHold(productId)).Returns(true);

        var order = new Order(mockInventory.Object);

        order.AddItem(productId);

        var productQuantity = order.GetProductQuantity(productId);

        Assert.That(productQuantity, Is.EqualTo(1));
    }

    [Test]
    public void AddingItem_WhenInsufficientStockAndNoStockOnHold_ThenClearItemFromOrder()
    {
        const int productId = 327;

        var mockInventory = new Mock<IInventory>();

        var order = new Order(mockInventory.Object);

        order.AddItem(productId);

        var productQuantity = order.GetProductQuantity(productId);

        Assert.That(productQuantity, Is.EqualTo(0));
    }

}