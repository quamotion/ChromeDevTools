using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fires when a Named Flow is created.
	/// </summary>
	[Event(ProtocolName.CSS.NamedFlowCreated)]
	[SupportedBy("iOS-9.3")]
	public class NamedFlowCreatedEvent
	{
		/// <summary>
		/// Gets or sets The new Named Flow.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public NamedFlow NamedFlow { get; set; }
	}
}
