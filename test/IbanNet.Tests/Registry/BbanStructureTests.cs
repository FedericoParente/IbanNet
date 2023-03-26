﻿using IbanNet.Registry.Patterns;

namespace IbanNet.Registry;

public class BbanStructureTests
{
    [Fact]
    public void When_creating_with_null_pattern_it_should_throw()
    {
        Pattern? pattern = null;

        // Act
        Func<BbanStructure> act = () => new BbanStructure(pattern!);

        // Assert
        act.Should()
            .Throw<ArgumentNullException>()
            .WithParameterName(nameof(pattern));
    }
}
