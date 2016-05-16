using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
