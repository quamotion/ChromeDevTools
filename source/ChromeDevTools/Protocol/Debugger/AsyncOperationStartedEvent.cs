using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when an async operation is scheduled (while in a debugger stepping session).
	/// </summary>
	[Event(ProtocolName.Debugger.AsyncOperationStarted)]
	[SupportedBy("Chrome-Tip")]
	public class AsyncOperationStartedEvent
	{
		/// <summary>
		/// Gets or sets Information about the async operation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AsyncOperation Operation { get; set; }
	}
}
