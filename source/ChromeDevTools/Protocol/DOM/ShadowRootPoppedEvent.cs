using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when shadow root is popped from the element.
	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPopped)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class ShadowRootPoppedEvent
	{
		/// <summary>
		/// Gets or sets Host element id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long HostId { get; set; }
		/// <summary>
		/// Gets or sets Shadow root id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long RootId { get; set; }
	}
}
