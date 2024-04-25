
namespace StringBuilder;

/// <summary>
/// Describes a <c>StringBuilder</c>
/// </summary>
public interface IStringBuilder
{
    /// <summary>
    /// Append a <c>string</c> to the builder
    /// </summary>
    /// <param name="value">The <c>string</c> to append to the state</param>
    void Append(string value);

    /// <summary>
    /// Append a <c>char</c> to the builder
    /// </summary>
    /// <param name="character">The <c>char</c> to append to the state</param>
    void Append(char character);

    /// <summary>
    /// Append a line to the state of the builder
    /// </summary>
    /// <param name="value">The <c>string</c> to append as a new line to the state</param>
    void AppendLine(string value);

    /// <summary>
    /// Return the index of the first occourence of the specified substring
    /// </summary>
    /// <example>
    ///
    /// var sb = new StringBuilder();
    /// sb.Append("This is an example string");
    /// Console.WriteLine(sb.FirstIndexOf("ample")); // Prints 13
    ///
    /// </example>
    /// <param name="value"></param>
    /// <returns></returns>
    int FirstIndexOf(String value);

    /// <summary>
    /// Return a new instance of a <c>StringBuilder</c> with the state reversed
    /// </summary>
    /// <param name="value">The <c>string</c> to append as a new line to the state</param>
    StringBuilder Reverse(string value);

    /// <summary>
    /// Get the state of the builder as a <c>string</c>
    /// </summary>
    /// <returns>The current built up <c>string</c></returns>
    string ToString();
}