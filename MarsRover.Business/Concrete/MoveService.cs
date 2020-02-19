using MarsRover.Business.Abstract;
using MarsRover.Model.ConsoleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Concrete
{
    public class MoveService : IMoveService
    {
        public void MoveOn(Position position)
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.YCoordinate += 1;
                    break;
                case Directions.S:
                    position.YCoordinate -= 1;
                    break;
                case Directions.E:
                    position.XCoordinate += 1;
                    break;
                case Directions.W:
                    position.XCoordinate -= 1;
                    break;
                default:
                    break;
            }
        }
    }
}
