namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Ssds;

public interface ISsd : IBuilderDirector<ISsdBuilder>, IHasName
{
    public int MemoryAmount { get; }
    public int MaximumSpeed { get; }
    public int PowerConsumption { get; }
    public string ConnectionOption { get; }
}