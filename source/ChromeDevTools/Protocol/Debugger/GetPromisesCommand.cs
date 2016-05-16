using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information about all <code>Promise</code>s that were created or updated after the <code>enablePromiseTracker</code> command, and have not been garbage collected yet.
	/// </summary>
	[Command(ProtocolName.Debugger.GetPromises)]
	[SupportedBy("Chrome-Tip")]
	public class GetPromisesCommand
	{
	}
}
