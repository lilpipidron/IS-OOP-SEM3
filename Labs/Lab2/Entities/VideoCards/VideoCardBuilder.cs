using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCards;

public class VideoCardBuilder : IVideoCardBuilder
{
    private int? _height;
    private int? _width;
    private int? _memoryAmount;
    private string? _versionPciE;
    private double? _chipFrequency;
    private int? _powerConsumption;

    public IVideoCardBuilder WithDimension(int height, int width)
    {
        _height = height;
        _width = width;
        return this;
    }

    public IVideoCardBuilder WithMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public IVideoCardBuilder WithVersionPciE(string versionPciE)
    {
        _versionPciE = versionPciE;
        return this;
    }

    public IVideoCardBuilder WithChipFrequency(double chipFrequency)
    {
        _chipFrequency = chipFrequency;
        return this;
    }

    public IVideoCardBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public IVideoCard Build()
    {
        return new VideoCard(
            _height ?? throw new ArgumentNullException(nameof(_height)),
            _width ?? throw new ArgumentNullException(nameof(_width)),
            _memoryAmount ?? throw new ArgumentNullException(nameof(_memoryAmount)),
            _versionPciE ?? throw new ArgumentNullException(nameof(_versionPciE)),
            _chipFrequency ?? throw new ArgumentNullException(nameof(_chipFrequency)),
            _powerConsumption ?? throw new ArgumentNullException(nameof(_powerConsumption)));
    }
}