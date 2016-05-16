using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Command(ProtocolName.Worker.ConnectToWorker)]
	[SupportedBy("Chrome-Tip")]
	public class ConnectToWorkerCommand
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string WorkerId { get; set; }
	}
}
