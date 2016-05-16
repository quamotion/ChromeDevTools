using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspectNodeRequested' event upon element selection.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetInspectModeEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetInspectModeEnabledCommandResponse
	{
	}
}
