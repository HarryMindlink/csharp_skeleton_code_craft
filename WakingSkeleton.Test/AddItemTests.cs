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

        order.AddItem(productId, 1);

        var productQuantity = order.GetProductQuantity(productId);

        Assert.That(productQuantity, Is.EqualTo(1));
    }

    [Test]
    public void AddingItem_WhenSufficientStock_PlacesTemporaryHold()
    {
        int productId = 327;

        Inventory inventory = new Inventory();

        int heldCount = inventory.GetHeldCountForProduct(productId);
        Assert.That(heldCount, Is.EqualTo(1));
    }

    [Test]
    public void AddingItem_WhenInsufficientStockAndNoStockOnHold_ThenClearItemFromOrder()
    {
        const int productId = 327;

        var mockInventory = new Mock<IInventory>();

        var order = new Order(mockInventory.Object);

        order.AddItem(productId, 1);

        var productQuantity = order.GetProductQuantity(productId);

        Assert.That(productQuantity, Is.EqualTo(0));
    }

}