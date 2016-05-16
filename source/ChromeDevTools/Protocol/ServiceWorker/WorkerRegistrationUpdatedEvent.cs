using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerRegistrationUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class WorkerRegistrationUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Registrations
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ServiceWorkerRegistration[] Registrations { get; set; }
	}
}
