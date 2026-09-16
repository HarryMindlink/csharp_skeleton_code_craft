namespace GuitarShack;

public class Order(IInventory inventory)
{
    private int _quantity;

    public int GetProductQuantity(int productId)
    {
        return _quantity;
    }

    public void AddItem(int productId, int quantity)
    {
        if (!inventory.TryAddHold(productId))
            return;

        _quantity++;
    }
}