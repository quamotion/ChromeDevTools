using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when a pseudo element is removed from an element.
	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementRemoved)]
	[SupportedBy("Chrome-Tip")]
	public class PseudoElementRemovedEvent
	{
		/// <summary>
		/// Gets or sets Pseudo element's parent element id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or sets The removed pseudo element id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long PseudoElementId { get; set; }
	}
}
