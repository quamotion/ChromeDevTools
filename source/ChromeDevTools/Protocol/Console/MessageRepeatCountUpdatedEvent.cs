using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Is not issued. Will be gone in the future versions of the protocol.
	/// </summary>
	[Event(ProtocolName.Console.MessageRepeatCountUpdated)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class MessageRepeatCountUpdatedEvent
	{
		/// <summary>
		/// Gets or sets New repeat count value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long Count { get; set; }
		/// <summary>
		/// Gets or sets Timestamp of most recent message in batch.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public double Timestamp { get; set; }
	}
}
