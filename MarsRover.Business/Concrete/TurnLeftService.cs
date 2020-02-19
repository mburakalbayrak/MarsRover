using MarsRover.Business.Abstract;
using MarsRover.Model.ConsoleModel;

namespace MarsRover.Business.Concrete
{
    public class TurnLeftService : ITurnLeftService
    {
        public void RotateLeft(Position position)
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Direction = Directions.W;
                    break;
                case Directions.S:
                    position.Direction = Directions.E;
                    break;
                case Directions.E:
                    position.Direction = Directions.N;
                    break;
                case Directions.W:
                    position.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }
    }
}
