﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    /// <summary>
    /// <para>
    /// Supports merging two different versions of the protocol into a single protocol. All commands,
    /// types and events for each domain are merged into the target domain. Commands, types and events
    /// are tagged with the <see cref="ProtocolItem.SupportedBy"/> property, to indicate which versions
    /// of the protocol support them.
    /// </para>
    /// <para>
    /// Additionally, commands and types can change over time. Commands can gain/loose arguments and return
    /// values, and types can gain/loose properties. The individual arguments, return values and properties
    /// are also tagged, indicating which version of the protocol supports them.
    /// </para>
    /// </summary>
    class ProtocolMerger
    {
        /// <summary>
        /// Merges one version of a protocol (for example, iOS 9.3) into another version of a protocl
        /// (for example, Chrome 1.1).
        /// </summary>
        /// <param name="source">
        /// The protocol to merge from.
        /// </param>
        /// <param name="target">
        /// The protocol to merge into.
        /// </param>
        public static void Merge(Protocol source, Protocol target)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            foreach (var domain in source.Domains)
            {
                if (!target.Domains.Contains(domain, NameEqualityComparer<Domain>.Instance))
                {
                    target.Domains.Add(domain);
                }
                else
                {
                    Merge(source, domain, target.Domains.Single(t => NameEqualityComparer<Domain>.Instance.Equals(domain, t)));
                }
            }
        }

        /// <summary>
        /// Merges all commands, events and types from a <paramref name="source"/> domain into a
        /// <paramref name="target"/> domain.
        /// </summary>
        /// <param name="protocol">
        /// The source protocol. Used to get the alias for the protocol.
        /// </param>
        /// <param name="source">
        /// The domain to merge from.
        /// </param>
        /// <param name="target">
        /// The domain to merge into.
        /// </param>
        static void Merge(Protocol protocol, Domain source, Domain target)
        {
            if (protocol == null)
            {
                throw new ArgumentNullException(nameof(protocol));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            Merge(protocol, source, source.Commands, target.Commands, (s, t) => false);
            Merge(protocol, source, source.Events, target.Events, (s, t) => false);
            Merge(protocol, source, source.Types, target.Types, (s, t) => false);
        }

        /// <summary>
        /// Merges a collection of protocol items (such as commands, events or types) into another one.
        /// </summary>
        /// <typeparam name="T">
        /// The type of item to merge.
        /// </typeparam>
        /// <param name="protocol">
        /// The source protocol. Used to get the alias for the protocol.
        /// </param>
        /// <param name="domain">
        /// The domain to merge from. Used to get the name of the domain.
        /// </param>
        /// <param name="source">
        /// The collection of items to merge from.
        /// </param>
        /// <param name="target">
        /// The collection of items to merge into.
        /// </param>
        static void Merge<T>(Protocol protocol, Domain domain, Collection<T> source, Collection<T> target, Func<T, T, bool> mergeAction)
            where T : ProtocolItem
        {
            if (protocol == null)
            {
                throw new ArgumentNullException(nameof(protocol));
            }

            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            // Go over all items, one by one
            foreach (var sourceItem in source)
            {
                // First, compare by name. If the target does not contain an item with the same name,
                // just add the current item.
                if (!target.Contains(sourceItem, NameEqualityComparer<T>.Instance))
                {
                    target.Add(sourceItem);
                }
                else
                {
                    // Else, get the item with the same name that already exists.
                    var targetItem = target.Single(t => NameEqualityComparer<T>.Instance.Equals(sourceItem, t));

                    // Figure out if it is equivalent
                    if (!targetItem.Equals(sourceItem))
                    {
                        bool couldMerge = mergeAction(sourceItem, targetItem);

                        // If it is not, we may need to apply a merge policy, or fail.
                        if (!couldMerge)
                        {
                            Console.WriteLine($"{protocol.Alias};{domain.Name};{sourceItem.Name};{sourceItem};{targetItem};{typeof(T).Name}");
                        }
                    }
                    else
                    {
                        // If it is, just add the supportedBy flag.
                        foreach (var v in sourceItem.SupportedBy)
                        {
                            targetItem.SupportedBy.Add(v);
                        }
                    }
                }
            }
        }
    }
}
