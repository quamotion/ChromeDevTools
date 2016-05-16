using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HighlightFrame)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class HighlightFrameCommandResponse
	{
	}
}
