using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired if request ended up loading from cache.
	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromCache)]
	[SupportedBy("Chrome-Tip")]
	public class RequestServedFromCacheEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RequestId { get; set; }
	}
}
