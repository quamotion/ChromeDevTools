using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
	/// </summary>
	[Event(ProtocolName.Debugger.Paused)]
	[SupportedBy("Chrome-Tip")]
	public class PausedEvent
	{
		/// <summary>
		/// Gets or sets Call stack the virtual machine stopped on.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets Pause reason.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Reason { get; set; }
		/// <summary>
		/// Gets or sets Object containing break-specific auxiliary properties.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Data { get; set; }
		/// <summary>
		/// Gets or sets Hit breakpoints IDs
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[] HitBreakpoints { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StackTrace AsyncStackTrace { get; set; }
	}
}
