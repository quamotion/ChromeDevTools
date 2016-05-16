using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Fired when <code>Element</code>'s attribute is modified.
	/// </summary>
	[Event(ProtocolName.DOM.AttributeModified)]
	[SupportedBy("Chrome-Tip")]
	public class AttributeModifiedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Attribute name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Attribute value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
	}
}
