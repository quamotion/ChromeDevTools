using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.DebugOnStartUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class DebugOnStartUpdatedEvent
	{
		/// <summary>
		/// Gets or sets DebugOnStart
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool DebugOnStart { get; set; }
	}
}
