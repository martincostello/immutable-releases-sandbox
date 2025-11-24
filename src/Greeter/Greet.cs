namespace Greeter;

/// <summary>
/// A simple greeter class.
/// </summary>
public static class Greet
{
    /// <summary>
    /// Returns a greeting message for the specified name.
    /// </summary>
    /// <param name="name">The name of the person to greet.</param>
    /// <returns>A greeting message.</returns>
    public static string SayHello(string name) => $"Hello, {name}!";
}
