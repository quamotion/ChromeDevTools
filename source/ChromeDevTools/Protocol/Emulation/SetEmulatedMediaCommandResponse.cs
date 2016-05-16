using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetEmulatedMedia)]
	[SupportedBy("Chrome-Tip")]
	public class SetEmulatedMediaCommandResponse
	{
	}
}
