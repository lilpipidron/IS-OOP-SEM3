namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engine;

public class AlphaEngine : JumpEngine
{
    public AlphaEngine(int fuelAmount, int jumpDistance)
        : base(fuelAmount, jumpDistance)
    {
    }

    public override bool Move(int distance)
    {
        return Fuel.Use(distance) >= 0;
    }
}