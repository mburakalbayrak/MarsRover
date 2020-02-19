using MarsRover.Business.Abstract;
using MarsRover.Model.ConsoleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Helper
{
    public class StartMove
    {
        public static void Moving(Position position, List<int> maxPoints, string moves, IMoveService moveService, ITurnLeftService turnleftService, ITurnRightService turnRightService )
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        moveService.MoveOn(position);
                        break;
                    case 'L':
                        turnleftService.RotateLeft(position);
                        break;
                    case 'R':
                        turnRightService.RotateRight(position);
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (position.XCoordinate < 0 || position.XCoordinate > maxPoints[0] || position.YCoordinate < 0 || position.YCoordinate > maxPoints[1])
                {
                    throw new Exception($"Oops! Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
        }
    }
}
