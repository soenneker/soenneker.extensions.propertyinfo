using System.Diagnostics.Contracts;
using System.Reflection;

namespace Soenneker.Extensions.PropertyInfo;

/// <summary>
/// A collection of helpful PropertyInfo (Reflection) extension methods
/// </summary>
public static class PropertyInfoExtension
{
    /// <summary>
    /// Determines whether the specified property is a constant.
    /// </summary>
    /// <param name="property">The property to check.</param>
    /// <returns><c>true</c> if the property is a constant; otherwise, <c>false</c>.</returns>
    [Pure]
    public static bool IsConstant(this System.Reflection.PropertyInfo property)
    {
        MethodInfo? getMethod = property.GetMethod;

        if (getMethod == null || !property.IsReadOnly())
        {
            // If there's no getter or the property is not read-only, it's not constant
            return false;
        }

        // If the property meets the above conditions, it's likely a constant
        return true;
    }

    [Pure]
    public static bool IsReadOnly(this System.Reflection.PropertyInfo property)
    {
        return !property.CanWrite;
    }
}