using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Disables debugger for given page.
	/// </summary>
	[Command(ProtocolName.Debugger.Disable)]
	[SupportedBy("Chrome-Tip")]
	public class DisableCommand
	{
	}
}
