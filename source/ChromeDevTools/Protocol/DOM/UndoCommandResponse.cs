using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Undo)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class UndoCommandResponse
	{
	}
}
