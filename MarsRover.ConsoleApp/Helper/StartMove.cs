using MarsRover.Business.Abstract;
using MarsRover.Model.ConsoleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Helper
{
    public class StartMove
    {
        public static void Moving(Position position, List<int> maxPoints, string moves, IMoveService moveService)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        moveService.MoveOn(position);
                        break;
                    case 'L':
                        moveService.RotateLeft(position);
                        break;
                    case 'R':
                        moveService.RotateRight(position);
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (position.XCoordinate < 0 || position.XCoordinate > maxPoints[0] || position.YCoordinate < 0 || position.YCoordinate > maxPoints[1])
                {
                    throw new Exception($"Error! Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]}). Current position is X:{position.XCoordinate},Y{position.YCoordinate}");
                }
            }
        }
    }
}
