using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when data chunk was received over the network.
	/// </summary>
	[Event(ProtocolName.Network.DataReceived)]
	[SupportedBy("Chrome-Tip")]
	public class DataReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Data chunk length.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long DataLength { get; set; }
		/// <summary>
		/// Gets or sets Actual bytes received (might be less than dataLength for compressed encodings).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long EncodedDataLength { get; set; }
	}
}
