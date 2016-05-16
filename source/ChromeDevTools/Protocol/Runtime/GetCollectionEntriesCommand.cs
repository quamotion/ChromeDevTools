using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns entries of given Map / Set collection.
	/// </summary>
	[Command(ProtocolName.Runtime.GetCollectionEntries)]
	[SupportedBy("iOS-9.3")]
	public class GetCollectionEntriesCommand
	{
		/// <summary>
		/// Gets or sets Id of the collection to get entries for.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple. If not provided, it will be the same objectGroup as the RemoteObject determined from <code>objectId</code>. This is useful for WeakMap to release the collection entries.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or sets If provided skip to this index before collecting values. Otherwise, 0.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long StartIndex { get; set; }
		/// <summary>
		/// Gets or sets If provided only return <code>numberToFetch</code> values. Otherwise, return values all the way to the end.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NumberToFetch { get; set; }
	}
}
