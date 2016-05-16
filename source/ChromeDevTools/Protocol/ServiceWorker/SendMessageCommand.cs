using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.SendMessage)]
	[SupportedBy("Chrome-Tip")]
	public class SendMessageCommand
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
