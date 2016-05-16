using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>
	[Command(ProtocolName.Worker.CanInspectWorkers)]
	[SupportedBy("iOS-9.3")]
	public class CanInspectWorkersCommand
	{
	}
}
