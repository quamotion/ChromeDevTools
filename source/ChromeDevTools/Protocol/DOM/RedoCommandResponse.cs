using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Redo)]
	[SupportedBy("Chrome-Tip")]
	public class RedoCommandResponse
	{
	}
}
