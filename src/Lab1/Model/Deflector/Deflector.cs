using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Deflector;

public abstract class Deflector
{
    protected Deflector(int asteroidDamage, int meteoriteDamage, int whaleDamage, int healthPoints)
    {
        AsteroidDamage = asteroidDamage;
        MeteoriteDamage = meteoriteDamage;
        HealthPoints = healthPoints;
        WhaleDamage = whaleDamage;
        Works = true;
    }

    private int AsteroidDamage { get; }
    private int MeteoriteDamage { get; }
    private int WhaleDamage { get; }
    private int HealthPoints { get; set; }
    private bool Works { get; set; }

    public virtual Obstacle? GetDamage(Obstacle obstacle)
    {
        if (Works == false || obstacle == null)
        {
            return obstacle;
        }

        switch (obstacle)
        {
            case Asteroid:
                obstacle.GetDamage(double.Min(AsteroidDamage, HealthPoints) / AsteroidDamage);
                HealthPoints -= AsteroidDamage;
                break;
            case Meteorite:
                obstacle.GetDamage(double.Min(MeteoriteDamage, HealthPoints) / MeteoriteDamage);
                HealthPoints -= MeteoriteDamage;
                break;
            case CosmoWhale:
                obstacle.GetDamage(double.Min(WhaleDamage, HealthPoints) / WhaleDamage);
                HealthPoints -= WhaleDamage;
                if (WhaleDamage == 0)
                {
                    Works = false;
                    return obstacle;
                }

                break;
        }

        if (HealthPoints < 0)
        {
            Works = false;
            return obstacle;
        }

        return null;
    }
}