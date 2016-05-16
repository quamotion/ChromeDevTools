using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Event(ProtocolName.Worker.DispatchMessageFromWorker)]
	[SupportedBy("Chrome-Tip")]
	public class DispatchMessageFromWorkerEvent
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
