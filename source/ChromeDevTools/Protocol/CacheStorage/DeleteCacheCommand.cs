using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[Command(ProtocolName.CacheStorage.DeleteCache)]
	[SupportedBy("Chrome-Tip")]
	public class DeleteCacheCommand
	{
		/// <summary>
		/// Gets or sets Id of cache for deletion.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CacheId { get; set; }
	}
}
