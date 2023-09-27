using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Enivorment;

public abstract class Environment
{
    public abstract bool CanMove(Engine.Engine engine);
    public abstract Collection<Obstacle.Obstacle> GetAllObstacles();
}