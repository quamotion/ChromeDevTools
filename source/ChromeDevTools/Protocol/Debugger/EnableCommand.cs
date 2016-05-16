using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Enables debugger for the given page. Clients should not assume that the debugging has been enabled until the result for this command is received.
	/// </summary>
	[Command(ProtocolName.Debugger.Enable)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class EnableCommand
	{
	}
}
