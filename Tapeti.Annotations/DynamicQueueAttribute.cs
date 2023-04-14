using System;
using JetBrains.Annotations;

namespace Tapeti.Annotations
{
    /// <summary>
    /// Creates a non-durable auto-delete queue to receive messages. Can be used
    /// on an entire MessageController class or on individual methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    [MeansImplicitUse]
    [PublicAPI]
    #if NET6_0_OR_GREATER // Tapeti 2 is the last version to support .NET Standard 2.0 in the core package, so there is no upgrade path for older clients.
    [Obsolete("Use the DynamicQueue attribute from Tapeti.Config.Annotations")]
    #endif
    public class DynamicQueueAttribute : Attribute
    {
        /// <summary>
        /// An optional prefix. If specified, Tapeti will compose the queue name using the
        /// prefix and a unique ID. If not specified, an empty queue name will be passed
        /// to RabbitMQ thus letting it create a unique queue name.
        /// </summary>
        public string Prefix { get; set; }


        /// <inheritdoc />
        /// <param name="prefix">An optional prefix. If specified, Tapeti will compose the queue name using the
        /// prefix and a unique ID. If not specified, an empty queue name will be passed
        /// to RabbitMQ thus letting it create a unique queue name.</param>
        public DynamicQueueAttribute(string prefix = null)
        {
            Prefix = prefix;
        }
    }
}
