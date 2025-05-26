using AwesomeAssertions;
using Soenneker.Extensions.PropertyInfo.Tests.Dtos;
using Xunit;

namespace Soenneker.Extensions.PropertyInfo.Tests;

public class PropertyInfoExtensionTests
{
    [Fact]
    public void IsConstant_should_be_false()
    {
        System.Reflection.PropertyInfo[] propertyInfo = typeof(Product).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
    }
}