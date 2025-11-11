using System;
using VirtualPark.ReflectionAbstractions;

namespace VirtualPark.Reflection.Test.PluginDoubles;

public sealed class NeedsArgStrategy : IStrategy
{
    public string InitMessage { get; }

    public NeedsArgStrategy(string message)
    {
        InitMessage = message;
    }

    public string Key => "NeedsArg";

    public int CalculatePoints(Guid token)
    {
        return InitMessage?.Length ?? 0;
    }
}
