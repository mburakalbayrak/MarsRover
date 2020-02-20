using MarsRover.Business.Abstract;
using MarsRover.Model.ConsoleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.ConsoleApp.Helper
{
    public class CommandHelper
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

                CheckPosition(position, maxPoints);
            }
        }

        public static void CheckMaxPoints(List<int> maxPoints)
        {
            if (maxPoints.Count() != 2)
            {
                ////Console.WriteLine("Error! Invalid maxPoints.");
                ////Console.ReadLine();
                ////return;
                throw new Exception($"Error! Invalid maxPoints.");
            }
        }

        public static void CheckPosition(Position position, List<int> maxPoints)
        {
            if (position.XCoordinate < 0 || position.XCoordinate > maxPoints[0] || position.YCoordinate < 0 || position.YCoordinate > maxPoints[1])
            {
                ////Console.WriteLine($"Error! Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]}). Current position is X:{position.XCoordinate},Y{position.YCoordinate}");
                ////Console.ReadLine();
                ////return;
                throw new Exception($"Error! Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]}). Current position is X:{position.XCoordinate},Y{position.YCoordinate}");
            }

            if (int.TryParse(position.Direction.ToString(), out int a))
            {
                ////Console.WriteLine($"Error! Direction is invalid. İnput:{position.XCoordinate},{position.YCoordinate},{a}");
                ////Console.ReadLine();
                ////return;
                throw new Exception($"Error! Direction is invalid. İnput:{position.XCoordinate},{position.YCoordinate},{a}");
            }
        }
    }
}
