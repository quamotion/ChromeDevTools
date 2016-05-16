using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when distrubution is changed.
	/// </summary>
	[Event(ProtocolName.DOM.DistributedNodesUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class DistributedNodesUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Insertion point where distrubuted nodes were updated.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long InsertionPointId { get; set; }
		/// <summary>
		/// Gets or sets Distributed nodes for given insertion point.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public BackendNode[] DistributedNodes { get; set; }
	}
}
