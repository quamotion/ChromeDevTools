using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestEntries)]
	[SupportedBy("Chrome-Tip")]
	public class RequestEntriesCommand
	{
		/// <summary>
		/// Gets or sets ID of cache to get entries from.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or sets Number of records to skip.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long SkipCount { get; set; }
		/// <summary>
		/// Gets or sets Number of records to fetch.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long PageSize { get; set; }
	}
}
