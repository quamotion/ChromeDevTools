using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Fired when <code>Element</code>'s inline style is modified via a CSS property modification.
	/// </summary>
	[Event(ProtocolName.DOM.InlineStyleInvalidated)]
	[SupportedBy("Chrome-Tip")]
	public class InlineStyleInvalidatedEvent
	{
		/// <summary>
		/// Gets or sets Ids of the nodes for which the inline styles have been invalidated.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long[] NodeIds { get; set; }
	}
}
