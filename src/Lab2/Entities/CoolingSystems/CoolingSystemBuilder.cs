using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Model.Dimensions;
using Itmo.ObjectOrientedProgramming.Lab2.Model.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystems;

public class CoolingSystemBuilder : ICoolingSystemBuilder
{
    private Dimension.CoolingDimension? _dimension;
    private IReadOnlyCollection<PcSocket>? _socket;
    private int? _maxTdp;

    public ICoolingSystemBuilder WithMaxTdp(int maxTdp)
    {
        _maxTdp = maxTdp;
        return this;
    }

    public ICoolingSystemBuilder WithSocket(IEnumerable<PcSocket> socket)
    {
        _socket = socket.ToArray();
        return this;
    }

    public ICoolingSystemBuilder WithDimension(Dimension.CoolingDimension dimension)
    {
        _dimension = dimension;
        return this;
    }

    public ICoolingSystem Build()
    {
        return new CoolingSystem(
            _dimension ?? throw new ArgumentNullException(nameof(_dimension)),
            _socket ?? throw new ArgumentNullException(nameof(_socket)),
            _maxTdp ?? throw new ArgumentNullException(nameof(_maxTdp)));
    }
}