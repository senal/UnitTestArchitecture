using ArchUnitNET.Domain;
using ArchUnitNET.Loader;

namespace Customer.Tests.ArchitectureTests;

public class ValidateArchitecture
{
    private static readonly Architecture architecture = new ArchLoader().LoadAssemblies(typeof(Program)).Build();
}