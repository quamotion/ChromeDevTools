using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Fired when backend wants to provide client with the missing DOM structure. This happens upon most of the calls requesting node ids.
	/// </summary>
	[Event(ProtocolName.DOM.SetChildNodes)]
	[SupportedBy("Chrome-Tip")]
	public class SetChildNodesEvent
	{
		/// <summary>
		/// Gets or sets Parent node id to populate with children.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or sets Child nodes array.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Node[] Nodes { get; set; }
	}
}
