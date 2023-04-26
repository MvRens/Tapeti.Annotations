using JetBrains.Annotations;
using System;

namespace Tapeti.Annotations
{
    /// <summary>
    /// Indicates that the method only handles response messages which are sent directly
    /// to the queue. No binding will be created.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [PublicAPI]
    #if NET6_0_OR_GREATER // Tapeti 2 is the last version to support .NET Standard 2.0 in the core package, so there is no upgrade path for older clients.
    [Obsolete("Use the ResponseHandler attribute from Tapeti.Config.Annotations")]
    #endif
    public class ResponseHandlerAttribute : Attribute
    {
    }
}
