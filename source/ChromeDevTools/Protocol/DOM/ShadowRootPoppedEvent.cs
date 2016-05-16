using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when shadow root is popped from the element.
	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPopped)]
	[SupportedBy("Chrome-Tip")]
	public class ShadowRootPoppedEvent
	{
		/// <summary>
		/// Gets or sets Host element id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long HostId { get; set; }
		/// <summary>
		/// Gets or sets Shadow root id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long RootId { get; set; }
	}
}
