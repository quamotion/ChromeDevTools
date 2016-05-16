using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.DispatchMessage)]
	[SupportedBy("Chrome-Tip")]
	public class DispatchMessageEvent
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
