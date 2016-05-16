using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns entries of given collection.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetCollectionEntries)]
	[SupportedBy("Chrome-Tip")]
	public class GetCollectionEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of collection entries.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CollectionEntry[] Entries { get; set; }
	}
}
