using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>
	[Command(ProtocolName.DOM.MoveTo)]
	[SupportedBy("Chrome-Tip")]
	public class MoveToCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to move.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the element to drop the moved node into.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long TargetNodeId { get; set; }
		/// <summary>
		/// Gets or sets Drop node before this one (if absent, the moved node becomes the last child of <code>targetNodeId</code>).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long InsertBeforeNodeId { get; set; }
	}
}
