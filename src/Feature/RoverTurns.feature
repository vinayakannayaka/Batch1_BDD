Feature: RoverTurns

    As a rover operator
    I want the rover to make turns
    So that the rover is turn able.

    Scenario Outline: Rover rotates left
        Given Rover is in plateau at (<X>,<Y>) co-ordinates and facing <Direction>
        When the rover turns <Turn Direction>
        Then Rover turns to a new direction <New Direction> with same cordinates (<X>,<Y>)

        Examples: Left Direction
            | X | Y | Direction | New Direction | Turn Direction |
            | 1 | 1 | N         | W             | L              |
            | 1 | 1 | S         | E             | L              |
            | 1 | 1 | E         | N             | L              |
            | 1 | 1 | W         | S             | L              |

        Examples: Right Direction
            | X | Y | Direction | New Direction | Turn Direction |
            | 1 | 1 | N         | E             | R              |
            | 1 | 1 | S         | W             | R              |
            | 1 | 1 | E         | S             | R              |
            | 1 | 1 | W         | N             | R              |
