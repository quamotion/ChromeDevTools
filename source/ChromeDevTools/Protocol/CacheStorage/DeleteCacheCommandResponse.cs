using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.DeleteCache)]
	[SupportedBy("Chrome-Tip")]
	public class DeleteCacheCommandResponse
	{
	}
}
