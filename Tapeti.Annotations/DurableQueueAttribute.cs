using System;
using JetBrains.Annotations;

namespace Tapeti.Annotations
{
    /// <summary>
    /// Binds to an existing durable queue to receive messages. Can be used
    /// on an entire MessageController class or on individual methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    [MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
    [PublicAPI]
    #if NET6_0_OR_GREATER // Tapeti 2 is the last version to support .NET Standard 2.0 in the core package, so there is no upgrade path for older clients.
    [Obsolete("Use the DurableQueue attribute from Tapeti.Config.Annotations")]
    #endif
    public class DurableQueueAttribute : Attribute
    {
        /// <summary>
        /// Specifies the name of the durable queue (must already be declared).
        /// </summary>
        public string Name { get; set; }


        /// <inheritdoc />
        /// <param name="name">The name of the durable queue</param>
        public DurableQueueAttribute(string name)
        {
            Name = name;
        }
    }
}
