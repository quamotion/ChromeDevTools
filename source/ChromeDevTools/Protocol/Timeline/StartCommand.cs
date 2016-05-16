using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Deprecated.
	/// </summary>
	[Command(ProtocolName.Timeline.Start)]
	[SupportedBy("Chrome-Tip")]
	public class StartCommand
	{
		/// <summary>
		/// Gets or sets Samples JavaScript stack traces up to <code>maxCallStackDepth</code>, defaults to 5.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MaxCallStackDepth { get; set; }
		/// <summary>
		/// Gets or sets Whether instrumentation events should be buffered and returned upon <code>stop</code> call.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool BufferEvents { get; set; }
		/// <summary>
		/// Gets or sets Coma separated event types to issue although bufferEvents is set.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string LiveEvents { get; set; }
		/// <summary>
		/// Gets or sets Whether counters data should be included into timeline events.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IncludeCounters { get; set; }
		/// <summary>
		/// Gets or sets Whether events from GPU process should be collected.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IncludeGPUEvents { get; set; }
	}
}
