using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when a pseudo element is added to an element.
	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementAdded)]
	[SupportedBy("Chrome-Tip")]
	public class PseudoElementAddedEvent
	{
		/// <summary>
		/// Gets or sets Pseudo element's parent element id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or sets The added pseudo element.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Node PseudoElement { get; set; }
	}
}
