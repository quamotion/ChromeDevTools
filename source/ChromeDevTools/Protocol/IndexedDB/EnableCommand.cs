using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>
	[Command(ProtocolName.IndexedDB.Enable)]
	[SupportedBy("Chrome-Tip")]
	public class EnableCommand
	{
	}
}
