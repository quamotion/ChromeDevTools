using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerVersionUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class WorkerVersionUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Versions
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ServiceWorkerVersion[] Versions { get; set; }
	}
}
