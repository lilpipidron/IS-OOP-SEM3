using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Result;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle;

public class AntimatterFlash : IObstacle
{
    public Result DoDamage(Ship.Ship ship)
    {
        if (ship.Deflector is IPhotonicDecorator photonicDecorator)
        {
            return photonicDecorator.HandlePhotonicDamage();
        }

        return new Result.ObstacleNotReflected(0);
    }
}