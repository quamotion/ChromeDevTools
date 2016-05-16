using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerErrorReported)]
	[SupportedBy("Chrome-Tip")]
	public class WorkerErrorReportedEvent
	{
		/// <summary>
		/// Gets or sets ErrorMessage
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ServiceWorkerErrorMessage ErrorMessage { get; set; }
	}
}
