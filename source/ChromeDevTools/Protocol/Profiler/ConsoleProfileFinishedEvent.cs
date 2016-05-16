using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	[Event(ProtocolName.Profiler.ConsoleProfileFinished)]
	[SupportedBy("Chrome-Tip")]
	public class ConsoleProfileFinishedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Location of console.profileEnd().
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Profile
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CPUProfile Profile { get; set; }
		/// <summary>
		/// Gets or sets Profile title passed as argunet to console.profile().
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Title { get; set; }
	}
}
