using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when an async operation is completed (while in a debugger stepping session).
	/// </summary>
	[Event(ProtocolName.Debugger.AsyncOperationCompleted)]
	[SupportedBy("Chrome-Tip")]
	public class AsyncOperationCompletedEvent
	{
		/// <summary>
		/// Gets or sets ID of the async operation that was completed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Id { get; set; }
	}
}
