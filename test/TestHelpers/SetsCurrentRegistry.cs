namespace TestHelpers;

/// <summary>
/// Marker to disable parallel tests because it sets static current registry.
/// </summary>
[CollectionDefinition(nameof(SetsCurrentRegistry), DisableParallelization = true)]
public class SetsCurrentRegistry
{
}
