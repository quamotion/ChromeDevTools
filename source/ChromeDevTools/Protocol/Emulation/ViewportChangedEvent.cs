using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Fired when a visible page viewport has changed. Only fired when device metrics are overridden.
	/// </summary>
	[Event(ProtocolName.Emulation.ViewportChanged)]
	[SupportedBy("Chrome-Tip")]
	public class ViewportChangedEvent
	{
		/// <summary>
		/// Gets or sets Viewport description.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Viewport Viewport { get; set; }
	}
}
