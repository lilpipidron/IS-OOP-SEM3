namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Xmps;

public interface IXmpBuilder
{
    IXmpBuilder WithTimings(string timings);

    IXmpBuilder WithVoltage(int voltage);

    IXmpBuilder WithFrequency(int frequency);

    IXmp Build();
}