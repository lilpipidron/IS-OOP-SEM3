using Itmo.ObjectOrientedProgramming.Lab1.Model.Result;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflector;

public class Deflector2 : IDeflector
{
    private const int SmallDamage = 10;
    private double _healthPoints = 20;

    public ObstacleResults GetDamage(double damage)
    {
        double damageReduce = 1;
        if (_healthPoints <= 0)
        {
            return new ObstacleResults.ObstacleNotReflected(damage);
        }

        if (damage > SmallDamage)
        {
            damageReduce = 0.3;
        }

        damage *= damageReduce;

        if (damage > _healthPoints)
        {
            _healthPoints = 0;
            return new ObstacleResults.ObstacleNotReflected(damage - _healthPoints);
        }

        _healthPoints -= damage;
        return new ObstacleResults.ObstacleReflected(0);
    }
}