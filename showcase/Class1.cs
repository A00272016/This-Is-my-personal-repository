namespace UtilityLibraries;

/// <summary>
/// This Class Holds Extension Methods for the <seealso cref="system.string">string</seealso> datatypes
/// </summary>
public static class StringLibrary
{
    /// <summary>
    /// Dectets whether or not the first letter is an uppercase letter.
    /// </summary>
    /// <param name="str">Uses a string type to extend</param>
    /// <returns>True or False</returns>
    /// <example>
    /// Use this method to detect an upper case letter
    /// <code>
    /// var x = "Hello".StartsWithUpper();
    /// </code>
    /// </example>
    public static bool StartsWithUpper(this string? str)
    {
        
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}