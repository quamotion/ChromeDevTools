using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Command(ProtocolName.Worker.SendMessageToWorker)]
	[SupportedBy("Chrome-Tip")]
	public class SendMessageToWorkerCommand
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string WorkerId { get; set; }
		/// <summary>
		/// Gets or sets Message
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Message { get; set; }
	}
}
