using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	[Event(ProtocolName.ApplicationCache.NetworkStateUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class NetworkStateUpdatedEvent
	{
		/// <summary>
		/// Gets or sets IsNowOnline
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsNowOnline { get; set; }
	}
}
