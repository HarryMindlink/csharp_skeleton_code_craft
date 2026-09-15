namespace WakingSkeleton.Test;

[TestFixture]
public class MarsRoverInitializationTests
{
    [Test]
    public void InitializingRoverAtGivenPosition()
    {
        var rover = new Rover((2, 3), Direction.North);
        Assert.That(rover.Position, Is.EqualTo((2, 3)));
    }

    [Test]
    public void InitializingRoverWithGivenDirection()
    {
        var rover = new Rover((2, 3), Direction.North);
        Assert.That(rover.Direction, Is.EqualTo(Direction.North));
    }
}

/* Feature: Initialising the Mars Rover

   The rover is created with a starting position and heading.
   After initialisation, it should report the same position and heading.

   Scenario: Initialise rover at a given position and direction
     When the rover is initialised at position (2, 3) facing North
     Then the rover position should be (2, 3)
     And the rover heading should be North */