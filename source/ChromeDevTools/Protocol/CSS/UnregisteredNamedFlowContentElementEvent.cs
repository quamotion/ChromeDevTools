using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fires when a Named Flow's has been registered with a new content node.
	/// </summary>
	[Event(ProtocolName.CSS.UnregisteredNamedFlowContentElement)]
	[SupportedBy("iOS-9.3")]
	public class UnregisteredNamedFlowContentElementEvent
	{
		/// <summary>
		/// Gets or sets The document node id.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Named Flow identifier for which the new content element was unregistered.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string FlowName { get; set; }
		/// <summary>
		/// Gets or sets The node id of the unregistered content node.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long ContentNodeId { get; set; }
	}
}
