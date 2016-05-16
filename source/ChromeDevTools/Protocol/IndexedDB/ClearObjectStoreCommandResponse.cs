using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Clears all entries from an object store.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.ClearObjectStore)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class ClearObjectStoreCommandResponse
	{
	}
}
