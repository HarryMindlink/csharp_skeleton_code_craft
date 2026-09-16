namespace GuitarShack;

public class Inventory : IInventory
{
    public bool TryAddHold(int productId)
    {
        return true;
    }
}