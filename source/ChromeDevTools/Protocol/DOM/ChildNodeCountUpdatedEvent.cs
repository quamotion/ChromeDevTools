using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Fired when <code>Container</code>'s child node count has changed.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeCountUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class ChildNodeCountUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New node count.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ChildNodeCount { get; set; }
	}
}
