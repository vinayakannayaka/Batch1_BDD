using FluentAssertions;
using NUnit.Framework;

namespace MarsRovers.UnitTest
{
    class RoverTest
    {

        [Test]
        public void RoverTestInitiallize()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 2);
            rover.Direction.Should().Be("N");
            rover.Position.Should().Be(new Point(1,2));

        }

        [Test]
        public void RoverShouldTurnLeftFromNorth()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 2);
            rover.Turn("L");
            rover.Direction.Should().Be("W");
            rover.Position.Should().Be(new Point(1, 2));
        }

    }
}
