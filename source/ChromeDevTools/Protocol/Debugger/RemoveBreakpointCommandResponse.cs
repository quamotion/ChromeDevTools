using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RemoveBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveBreakpointCommandResponse
	{
	}
}
