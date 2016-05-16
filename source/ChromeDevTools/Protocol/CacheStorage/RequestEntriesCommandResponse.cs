using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.RequestEntries)]
	[SupportedBy("Chrome-Tip")]
	public class RequestEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of object store data entries.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public DataEntry[] CacheDataEntries { get; set; }
		/// <summary>
		/// Gets or sets If true, there are more entries to fetch in the given range.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool HasMore { get; set; }
	}
}
