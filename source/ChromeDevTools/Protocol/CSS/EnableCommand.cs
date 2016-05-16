using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been enabled until the result of this command is received.
	/// </summary>
	[Command(ProtocolName.CSS.Enable)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class EnableCommand
	{
	}
}
