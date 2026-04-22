using AwesomeAssertions;
using Soenneker.Extensions.PropertyInfo.Tests.Dtos;

namespace Soenneker.Extensions.PropertyInfo.Tests;

public class PropertyInfoExtensionTests
{
    [Test]
    public void IsConstant_should_be_false()
    {
        System.Reflection.PropertyInfo[] propertyInfo = typeof(Product).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
    }
}