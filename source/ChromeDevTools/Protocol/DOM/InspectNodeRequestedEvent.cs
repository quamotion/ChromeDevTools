using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Fired when the node should be inspected. This happens after call to <code>setInspectModeEnabled</code>.
	/// </summary>
	[Event(ProtocolName.DOM.InspectNodeRequested)]
	[SupportedBy("Chrome-Tip")]
	public class InspectNodeRequestedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node to inspect.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long BackendNodeId { get; set; }
	}
}
