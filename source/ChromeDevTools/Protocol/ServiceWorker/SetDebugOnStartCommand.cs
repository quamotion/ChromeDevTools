using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.SetDebugOnStart)]
	[SupportedBy("Chrome-Tip")]
	public class SetDebugOnStartCommand
	{
		/// <summary>
		/// Gets or sets DebugOnStart
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool DebugOnStart { get; set; }
	}
}
