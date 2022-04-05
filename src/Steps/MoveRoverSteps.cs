using FluentAssertions;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    [Binding]
    public class MoveRoverSteps
    {
        private readonly ScenarioContext _scenarioContext;
        Rover rover;

        public MoveRoverSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        //Given Rover is in plateau at (<X>,<Y>) co-ordinates and faces <Direction>
       [Given(@"Rover is in plateau at \((\d+),(\d+)\) co-ordinates and faces ([NEWS]{1})")]
        public void GivenRoverIsInPlateauAtCo_OrdinatesAndFacingFacing(int x, int y , string direction)
        {
            rover = new Rover();
            rover.Direction = direction;
            rover.Position = new Point(x, y);
        }

        [When(@"the rover moves")]
        public void WhenTheRoverMoves()
        {
            rover.Move(1);
        }

        [Then(@"the rover reaches new position \((\d+),(\d+)\) in the same ([NEWS]{1}).")]
        public void ThenTheRoverReachesNewPositionInTheSame(int x, int y, string direction)
        {
            rover.Direction.Should().Be(direction);
            rover.Position.Should().Be(new Point(x, y));
        }
        


    }
}





