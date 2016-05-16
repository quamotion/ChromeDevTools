using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when a "sound" breakpoint action is triggered on a breakpoint.
	/// </summary>
	[Event(ProtocolName.Debugger.PlayBreakpointActionSound)]
	[SupportedBy("iOS-9.3")]
	public class PlayBreakpointActionSoundEvent
	{
		/// <summary>
		/// Gets or sets Breakpoint action identifier.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long BreakpointActionId { get; set; }
	}
}
