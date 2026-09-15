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
        switch (Direction)
        {
            case Direction.North:
                Position = Position with { Item2 = Position.Item2 + 1 };
                break;
            case Direction.East:
                Position = Position with { Item1 = Position.Item1 + 1 };
                break;
            case Direction.South:
                Position = Position with { Item2 = Position.Item2 - 1 };
                break;
            default:
                Position = Position with { Item1 = Position.Item1 - 1 };
                break;
        }
    }
}