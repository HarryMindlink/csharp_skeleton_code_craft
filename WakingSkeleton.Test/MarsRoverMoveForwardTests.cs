using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace WakingSkeleton.Test;

[TestFixture]
public class MarsRoverMoveForwardTests
{
    public static IEnumerable<TestCaseData> RoverMovingForwardTestCases
    {
        get
        {
            yield return new TestCaseData(Direction.North, (1, 2));
            yield return new TestCaseData(Direction.East, (2, 1));
            yield return new TestCaseData(Direction.South, (1, 0));
        }
    }

    [Test]
    [TestCaseSource(nameof(RoverMovingForwardTestCases))]
    public void RoverMovingForwardChangesPosition(Direction direction, (int, int) expectedPosition)
    {
        Rover rover = new Rover((1, 1), direction);

        rover.CommandF();
        
        (int, int) actualPosition = rover.Position;
        Assert.That(actualPosition, Is.EqualTo(expectedPosition));
    }
}