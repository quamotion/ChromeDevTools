using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Mirrors <code>DOMNodeInserted</code> event.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeInserted)]
	[SupportedBy("Chrome-Tip")]
	public class ChildNodeInsertedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or sets If of the previous siblint.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long PreviousNodeId { get; set; }
		/// <summary>
		/// Gets or sets Inserted node data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Node Node { get; set; }
	}
}
