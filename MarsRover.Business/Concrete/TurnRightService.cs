using MarsRover.Business.Abstract;
using MarsRover.Model.ConsoleModel;

namespace MarsRover.Business.Concrete
{
    public class TurnRightService : ITurnRightService
    {
        public void RotateRight(Position position)
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Direction = Directions.E;
                    break;
                case Directions.S:
                    position.Direction = Directions.W;
                    break;
                case Directions.E:
                    position.Direction = Directions.S;
                    break;
                case Directions.W:
                    position.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
    }
}
