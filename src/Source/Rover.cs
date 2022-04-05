using System;

namespace MarsRovers
{
  class Rover
  {
        public string Direction { get; internal set; }
        public Point Position { get; internal set; }

        internal void Turn(string turnDirection)
        {
            if (turnDirection=="L")
            {
                TurnLeft();
            }
            else
            {
                TurnRight();
            }

        }

        void TurnRight()
        {
            if (Direction == "N")
            {
                Direction = "E";
                return;
            }
            if (Direction == "S")
            {
                Direction = "W";
                return;
            }
            if (Direction == "W")
            {
                Direction = "N";
                return;
            }
            if (Direction == "E")
            {
                Direction = "S";
                return;
            }
        }

        void TurnLeft()
        {
            if (Direction=="N")
            {
                Direction = "W";
                return ;
            }
            if (Direction=="S")
            {
                Direction = "E";
                return;
            }
            if (Direction=="W")
            {
                Direction = "S";
                return;
            }
            if (Direction=="E")
            {
                Direction = "N";
                return;
            }
        }

        internal void Move(int moveConrdinates)
        {
            if (Direction=="N")
            {
                Position = new Point(Position.X, Position.Y + moveConrdinates);
            }
            if (Direction == "S")
            {
                Position = new Point(Position.X, Position.Y - moveConrdinates);
            }
            if (Direction == "W")
            {
                Position = new Point(Position.X- moveConrdinates, Position.Y );
            }
            if (Direction == "E")
            {
                Position = new Point(Position.X + moveConrdinates, Position.Y);
            }
        }
      
  }
}