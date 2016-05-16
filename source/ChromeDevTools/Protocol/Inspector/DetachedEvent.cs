using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Fired when remote debugging connection is about to be terminated. Contains detach reason.
	/// </summary>
	[Event(ProtocolName.Inspector.Detached)]
	[SupportedBy("Chrome-Tip")]
	public class DetachedEvent
	{
		/// <summary>
		/// Gets or sets The reason why connection has been terminated.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Reason { get; set; }
	}
}
