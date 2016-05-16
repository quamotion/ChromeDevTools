using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Fired when <code>Element</code>'s attribute is removed.
	/// </summary>
	[Event(ProtocolName.DOM.AttributeRemoved)]
	[SupportedBy("Chrome-Tip")]
	public class AttributeRemovedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets A ttribute name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
	}
}
