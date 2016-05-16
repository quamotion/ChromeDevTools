using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets breakpoint on AsyncOperation callback handler.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetAsyncOperationBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class SetAsyncOperationBreakpointCommandResponse
	{
	}
}
