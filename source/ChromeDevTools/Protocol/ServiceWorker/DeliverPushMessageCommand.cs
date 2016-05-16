using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.DeliverPushMessage)]
	[SupportedBy("Chrome-Tip")]
	public class DeliverPushMessageCommand
	{
		/// <summary>
		/// Gets or sets Origin
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets RegistrationId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets Data
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Data { get; set; }
	}
}
