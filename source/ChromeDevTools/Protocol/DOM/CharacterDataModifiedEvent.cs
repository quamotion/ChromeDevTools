using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Mirrors <code>DOMCharacterDataModified</code> event.
	/// </summary>
	[Event(ProtocolName.DOM.CharacterDataModified)]
	[SupportedBy("Chrome-Tip")]
	public class CharacterDataModifiedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New text value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CharacterData { get; set; }
	}
}
