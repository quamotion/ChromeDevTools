using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Command(ProtocolName.Worker.SetAutoconnectToWorkers)]
	[SupportedBy("Chrome-Tip")]
	public class SetAutoconnectToWorkersCommand
	{
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Value { get; set; }
	}
}
