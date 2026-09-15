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
        if (Direction is Direction.North)
        {
            Position = Position with { Item2 = Position.Item2 + 1 };
        }
        else if(Direction is Direction.East)
        {
            Position = Position with { Item1 = Position.Item1 + 1 };
        }
        else
        {
            Position = Position with { Item2 = Position.Item2 - 1 };
        }
    }
}