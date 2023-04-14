using System;
using JetBrains.Annotations;

namespace Tapeti.Annotations
{
    /// <summary>
    /// Attaching this attribute to a class includes it in the auto-discovery of message controllers
    /// when using the RegisterAllControllers method. It is not required when manually registering a controller.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    [MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
    [PublicAPI]
    #if NET6_0_OR_GREATER // Tapeti 2 is the last version to support .NET Standard 2.0 in the core package, so there is no upgrade path for older clients.
    [Obsolete("Use the MessageController attribute from Tapeti.Config.Annotations")]
    #endif
    public class MessageControllerAttribute : Attribute
    {
    }
}
