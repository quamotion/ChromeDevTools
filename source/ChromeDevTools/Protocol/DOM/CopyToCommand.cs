using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Creates a deep copy of the specified node and places it into the target container before the given anchor.
	/// </summary>
	[Command(ProtocolName.DOM.CopyTo)]
	[SupportedBy("Chrome-Tip")]
	public class CopyToCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to copy.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the element to drop the copy into.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long TargetNodeId { get; set; }
		/// <summary>
		/// Gets or sets Drop the copy before this node (if absent, the copy becomes the last child of <code>targetNodeId</code>).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long InsertBeforeNodeId { get; set; }
	}
}
