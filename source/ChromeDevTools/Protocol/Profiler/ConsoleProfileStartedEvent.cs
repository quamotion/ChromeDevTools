using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Sent when new profile recodring is started using console.profile() call.
	/// </summary>
	[Event(ProtocolName.Profiler.ConsoleProfileStarted)]
	[SupportedBy("Chrome-Tip")]
	public class ConsoleProfileStartedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Location of console.profile().
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Profile title passed as argument to console.profile().
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Title { get; set; }
	}
}
