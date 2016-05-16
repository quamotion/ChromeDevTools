using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Dispatches a key event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchKeyEvent)]
	[SupportedBy("Chrome-Tip")]
	public class DispatchKeyEventCommandResponse
	{
	}
}
