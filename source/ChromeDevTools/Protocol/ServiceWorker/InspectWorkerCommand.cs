using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.InspectWorker)]
	[SupportedBy("Chrome-Tip")]
	public class InspectWorkerCommand
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string VersionId { get; set; }
	}
}
