using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Enables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Enable)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class EnableCommandResponse
	{
	}
}
