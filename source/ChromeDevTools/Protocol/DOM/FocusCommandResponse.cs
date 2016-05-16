using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Focus)]
	[SupportedBy("Chrome-Tip")]
	public class FocusCommandResponse
	{
	}
}
