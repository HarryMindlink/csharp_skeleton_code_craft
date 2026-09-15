namespace WakingSkeleton;

public class Rover
{
    public Direction Direction { get; }
    public (int, int) Position { get; private set; }

    public Rover((int, int) position, Direction direction)
    {
        Position = position;
        Direction = direction;
    }
    
    public void CommandF()
    {
        Position = Position with { Item2 = Position.Item2 + 1 };
    }
}