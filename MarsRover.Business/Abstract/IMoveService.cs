using MarsRover.Model.ConsoleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Abstract
{
    public interface IMoveService
    {
        void MoveOn(Position position);
    }
}
