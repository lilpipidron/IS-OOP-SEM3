using Itmo.ObjectOrientedProgramming.Lab1.Model.Result;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflector;

public interface IDeflector
{
    public ObstacleResults GetDamage(double damage);
}