using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fires when a Named Flow is removed: has no associated content nodes and regions.
	/// </summary>
	[Event(ProtocolName.CSS.NamedFlowRemoved)]
	[SupportedBy("iOS-9.3")]
	public class NamedFlowRemovedEvent
	{
		/// <summary>
		/// Gets or sets The document node id.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the removed Named Flow.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string FlowName { get; set; }
	}
}
