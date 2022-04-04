using System;

namespace MarsRovers
{
     class Rover
    {
        public string Direction { get; internal set; }
        public Point Position { get; internal set; }

        internal void Turn(string turnDirection)
        {
            Direction = "W";
        }
    }
}