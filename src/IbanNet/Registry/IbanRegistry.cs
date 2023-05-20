﻿using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using IbanNet.Registry.Swift;

namespace IbanNet.Registry;

/// <summary>
/// Represents a registry of IBAN countries.
/// </summary>
public class IbanRegistry : IIbanRegistry
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly Func<IIbanRegistry> DefaultFactory = () => Default;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static Lazy<IIbanRegistry> _currentInstance = new(
        DefaultFactory,
        LazyThreadSafetyMode.ExecutionAndPublication
    );

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private IDictionary<string, IbanCountry>? _dictionary;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly object _syncObject = new();

    /// <summary>
    /// Gets the default IBAN registry initialized with all the built-in countries provided by the <see cref="SwiftRegistryProvider" />.
    /// </summary>
    public static IbanRegistry Default { get; } = new()
    {
        // Read-only, so default can not be modified.
        Providers = new ReadOnlyCollection<IIbanRegistryProvider>(new IIbanRegistryProvider[] { new SwiftRegistryProvider() })
    };

    /// <summary>
    /// Gets or sets the current <see cref="IIbanRegistry" />. Defaults to <see cref="Default" />.
    /// <para>Set to <see langword="null" /> will reset the registry to <see cref="Default" />.</para>
    /// </summary>
    /// <remarks>When using dependency injection, this property is configured automatically.</remarks>
    [AllowNull]
    public static IIbanRegistry Current
    {
        get => _currentInstance.Value;
        set => _currentInstance = value is null
            ? new Lazy<IIbanRegistry>(DefaultFactory, true)
            : new Lazy<IIbanRegistry>(() => value, true);
    }

    /// <summary>
    /// Initializes a new instance of <see cref="IbanRegistry" />.
    /// </summary>
    // ReSharper disable once EmptyConstructor
    public IbanRegistry()
    {
    }

    /// <inheritdoc />
    public IEnumerator<IbanCountry> GetEnumerator() => Dictionary.Values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => Dictionary.Count;

    /// <summary>
    /// Gets the registry providers.
    /// </summary>
    /// <remarks>Note: after using any of the registry members (iow. getting country information), you can no longer modify this list.</remarks>
    public IList<IIbanRegistryProvider> Providers { get; internal set; } = new List<IIbanRegistryProvider>();

    /// <inheritdoc />
    // ReSharper disable once InconsistentNaming
    public bool TryGetValue(string twoLetterISORegionName, [NotNullWhen(true)] out IbanCountry? country) => Dictionary.TryGetValue(twoLetterISORegionName, out country);

    /// <inheritdoc />
    // ReSharper disable once InconsistentNaming
    public IbanCountry this[string twoLetterISORegionName] => Dictionary[twoLetterISORegionName];

    /// <summary>
    /// Gets the registry mapped as dictionary by country code.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private IDictionary<string, IbanCountry> Dictionary
    {
        get
        {
            if (_dictionary is not null)
            {
                return _dictionary;
            }

            lock (_syncObject)
            {
                var readOnlyProviders = new ReadOnlyCollection<IIbanRegistryProvider>(Providers.ToArray());
                try
                {
                    return _dictionary ??= new ReadOnlyDictionary<string, IbanCountry>(readOnlyProviders
                        .SelectMany(p => p)
                        // In case of duplicate country codes, select the first.
                        .GroupBy(c => c.TwoLetterISORegionName)
                        .ToDictionary(g => g.Key, g => g.First(), StringComparer.OrdinalIgnoreCase)
                    );
                }
                finally
                {
                    // Freeze providers, so that the collection can no longer be modified after hydrating the registry.
                    Providers = readOnlyProviders;
                }
            }
        }
    }
}
