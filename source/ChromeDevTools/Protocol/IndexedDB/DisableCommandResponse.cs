using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.Disable)]
	[SupportedBy("Chrome-Tip")]
	public class DisableCommandResponse
	{
	}
}
