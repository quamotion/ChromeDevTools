using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightRect)]
	[SupportedBy("Chrome-Tip")]
	public class HighlightRectCommandResponse
	{
	}
}
