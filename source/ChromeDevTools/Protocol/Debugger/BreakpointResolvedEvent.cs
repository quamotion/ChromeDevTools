using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when breakpoint is resolved to an actual script and location.
	/// </summary>
	[Event(ProtocolName.Debugger.BreakpointResolved)]
	[SupportedBy("Chrome-Tip")]
	public class BreakpointResolvedEvent
	{
		/// <summary>
		/// Gets or sets Breakpoint unique identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string BreakpointId { get; set; }
		/// <summary>
		/// Gets or sets Actual breakpoint location.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Location Location { get; set; }
	}
}
