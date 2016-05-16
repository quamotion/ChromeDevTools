using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetTouchEmulationEnabledCommandResponse
	{
	}
}
