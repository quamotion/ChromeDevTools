using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
	/// </summary>
	[Command(ProtocolName.Profiler.SetSamplingInterval)]
	[SupportedBy("Chrome-Tip")]
	public class SetSamplingIntervalCommand
	{
		/// <summary>
		/// Gets or sets New sampling interval in microseconds.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Interval { get; set; }
	}
}
