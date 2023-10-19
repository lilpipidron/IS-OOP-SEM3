namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFiAdapters;

public interface IWiFiAdapter : IBuilderDirector<IWiFiBuilder>, IHasName
{
    public int WifiVersion { get; }
    public bool Bluetooth { get; }
    public string VersionPciE { get; }
    public int PowerConsumption { get; }
}