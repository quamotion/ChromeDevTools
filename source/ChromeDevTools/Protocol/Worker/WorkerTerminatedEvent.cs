using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Event(ProtocolName.Worker.WorkerTerminated)]
	[SupportedBy("Chrome-Tip")]
	public class WorkerTerminatedEvent
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string WorkerId { get; set; }
	}
}
