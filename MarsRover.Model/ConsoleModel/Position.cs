namespace MarsRover.Model.ConsoleModel
{
    public enum Directions
    {
        N = 1,//North
        S = 2,//South
        E = 3,//East
        W = 4//West
    }
    public class Position
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Directions Direction { get; set; }

        public Position()
        {
            XCoordinate = YCoordinate = 0;
            Direction = Directions.N;
        }
    }

}
