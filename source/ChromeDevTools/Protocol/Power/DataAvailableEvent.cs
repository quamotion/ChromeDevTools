using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	[Event(ProtocolName.Power.DataAvailable)]
	[SupportedBy("Chrome-Tip")]
	public class DataAvailableEvent
	{
		/// <summary>
		/// Gets or sets List of power events.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public PowerEvent[] Value { get; set; }
	}
}
