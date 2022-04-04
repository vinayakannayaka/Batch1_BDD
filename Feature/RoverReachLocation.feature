Feature: RoverReachLocation

Rover should be successfully able to reach required location.

@tag1
Scenario Outline: Reach destination
Given Rover is in plateau and operated
When the rover accepts First line of input
| <X>       |
| <y>       |
| <Direction> |
And Second line of <Second input>
Then the rover reaches desired location <Location>
Examples: 
| X | y | Direction |Second input  | Location |
| 1 | 2 | N         | LMLMLMLMM	   | 1 3 N    |
| 3 | 3 | E         | MMRMMRMRRM   | 5 1 E    |