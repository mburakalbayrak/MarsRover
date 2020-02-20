using MarsRover.Business.Abstract;
using MarsRover.Business.Concrete;
using MarsRover.ConsoleApp.Helper;
using MarsRover.Model.ConsoleModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the plateau's upper-right coordinates (ex. 5 5) :");
                var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                CommandHelper.CheckMaxPoints(maxPoints);

                Console.Write("Enter the rover's start position (ex. 1 1 N) :");
                var startPositions = Console.ReadLine().Trim().Split(' ');

                Position position = new Position
                {
                    XCoordinate = Convert.ToInt32(startPositions[0]),
                    YCoordinate = Convert.ToInt32(startPositions[1]),
                    Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2].ToUpper())
                };

                CommandHelper.CheckPosition(position, maxPoints);

                var serviceProvider = new ServiceCollection()
                .AddSingleton<IMoveService, MoveService>()
                .BuildServiceProvider();

                Console.Write("Enter rover's moving sequence (ex. LMRMRMM) :");
                var moves = Console.ReadLine().ToUpper();

                var moveService = serviceProvider.GetService<IMoveService>();

                CommandHelper.Moving(position, maxPoints, moves, moveService);

                Console.WriteLine(string.Format(Environment.NewLine + "Current Position is: {0} {1} {2}", position.XCoordinate, position.YCoordinate, position.Direction));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
