using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Stability;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

public class Shuttle : Ship
{
    public Shuttle()
    {
        Engine = new EngineC();
        Stability = new Stability1();
    }

    private int DoW { get; set; } = 20;

    public override Obstacle.Obstacle? GetDamage(Obstacle.Obstacle obstacle)
    {
        return Stability?.GetDamage(obstacle);
    }
}