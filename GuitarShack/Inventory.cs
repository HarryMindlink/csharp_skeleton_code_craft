namespace GuitarShack;

public class Inventory : IInventory
{
    public bool TryAddHold(int productId)
    {
        return true;
    }

    public int GetHeldCountForProduct(int productId)
    {
        return 1;
    }
}