using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Disable)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class DisableCommandResponse
	{
	}
}
