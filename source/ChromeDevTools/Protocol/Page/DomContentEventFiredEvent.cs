using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	[Event(ProtocolName.Page.DomContentEventFired)]
	[SupportedBy("Chrome-Tip")]
	public class DomContentEventFiredEvent
	{
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
	}
}
