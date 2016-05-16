using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StartWorker)]
	[SupportedBy("Chrome-Tip")]
	public class StartWorkerCommand
	{
		/// <summary>
		/// Gets or sets ScopeURL
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScopeURL { get; set; }
	}
}
