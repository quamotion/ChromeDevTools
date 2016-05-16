using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when HTTP request has failed to load.
	/// </summary>
	[Event(ProtocolName.Network.LoadingFailed)]
	[SupportedBy("Chrome-Tip")]
	public class LoadingFailedEvent
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
		/// Gets or sets Resource type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets User friendly error message.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ErrorText { get; set; }
		/// <summary>
		/// Gets or sets True if loading was canceled.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Canceled { get; set; }
	}
}
