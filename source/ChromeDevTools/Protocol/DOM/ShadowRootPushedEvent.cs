using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when shadow root is pushed into the element.
	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPushed)]
	[SupportedBy("Chrome-Tip")]
	public class ShadowRootPushedEvent
	{
		/// <summary>
		/// Gets or sets Host element id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long HostId { get; set; }
		/// <summary>
		/// Gets or sets Shadow root.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Node Root { get; set; }
	}
}
