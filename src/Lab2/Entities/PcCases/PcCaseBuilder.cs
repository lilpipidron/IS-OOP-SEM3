using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Model.Dimensions;
using Itmo.ObjectOrientedProgramming.Lab2.Model.MotherboardFormFactors;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PcCases;

public class PcCaseBuilder : IPcCaseBuilder
{
    private Dimension.VideoCardDimension? _maxVideoCardDimension;
    private IReadOnlyCollection<MotherBoardFormFactor>? _motherBoardForms;
    private Dimension.CaseDimension? _dimension;

    public IPcCaseBuilder WithMaxVideoCardDimension(Dimension.VideoCardDimension maxDimension)
    {
        _maxVideoCardDimension = maxDimension;
        return this;
    }

    public IPcCaseBuilder WithMotherBoardForms(IEnumerable<MotherBoardFormFactor> motherBoardForms)
    {
        _motherBoardForms = motherBoardForms.ToArray();
        return this;
    }

    public IPcCaseBuilder WithDimension(Dimension.CaseDimension dimension)
    {
        _dimension = dimension;
        return this;
    }

    public IPcCase Build()
    {
        return new PcCase(
            _maxVideoCardDimension ?? throw new ArgumentNullException(nameof(_maxVideoCardDimension)),
            _motherBoardForms ?? throw new ArgumentNullException(nameof(_motherBoardForms)),
            _dimension ?? throw new ArgumentNullException(nameof(_dimension)));
    }
}