using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	[Event(ProtocolName.Page.LoadEventFired)]
	[SupportedBy("Chrome-Tip")]
	public class LoadEventFiredEvent
	{
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
	}
}
