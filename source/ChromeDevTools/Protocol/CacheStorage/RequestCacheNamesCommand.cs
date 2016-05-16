using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Requests cache names.
	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestCacheNames)]
	[SupportedBy("Chrome-Tip")]
	public class RequestCacheNamesCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SecurityOrigin { get; set; }
	}
}
