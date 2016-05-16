using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StopWorker)]
	[SupportedBy("Chrome-Tip")]
	public class StopWorkerCommand
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string VersionId { get; set; }
	}
}
