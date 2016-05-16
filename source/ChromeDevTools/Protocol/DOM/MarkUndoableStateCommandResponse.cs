using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.MarkUndoableState)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class MarkUndoableStateCommandResponse
	{
	}
}
