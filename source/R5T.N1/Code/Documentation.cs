using System;

using R5T.T0156;


namespace R5T.N1
{
    /// <summary>
    /// The location-anonymous namespace.
    /// </summary>
    /// <remarks>
    /// Location-anonymous types are those types for which their project location does not matter.
    /// Generally, there should only be one of each of these types.
    /// However, it is possible to have more than one of these types (same name, in different projects),
    /// but consumers of either type will be annoyed by having the alias their type names if both libraries are ever dependencies.
    /// </remarks>
    [DocumentationMarker]
	public static class Documentation
	{
	}
}