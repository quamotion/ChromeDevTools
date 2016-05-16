using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Mirrors <code>DOMNodeRemoved</code> event.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeRemoved)]
	[SupportedBy("Chrome-Tip")]
	public class ChildNodeRemovedEvent
	{
		/// <summary>
		/// Gets or sets Parent id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the node that has been removed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
