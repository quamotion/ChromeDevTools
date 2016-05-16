using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns entries of given Map / Set collection.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetCollectionEntries)]
	[SupportedBy("iOS-9.3")]
	public class GetCollectionEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of collection entries.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CollectionEntry[] Entries { get; set; }
	}
}
