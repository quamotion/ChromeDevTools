using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when a <code>Promise</code> is created, updated or garbage collected.
	/// </summary>
	[Event(ProtocolName.Debugger.PromiseUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class PromiseUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Type of the event.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string EventType { get; set; }
		/// <summary>
		/// Gets or sets Information about the updated <code>Promise</code>.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public PromiseDetails Promise { get; set; }
	}
}
