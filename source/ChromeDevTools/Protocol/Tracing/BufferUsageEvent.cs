using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Tracing
{
	[Event(ProtocolName.Tracing.BufferUsage)]
	[SupportedBy("Chrome-Tip")]
	public class BufferUsageEvent
	{
		/// <summary>
		/// Gets or sets A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double PercentFull { get; set; }
		/// <summary>
		/// Gets or sets An approximate number of events in the trace log.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double EventCount { get; set; }
		/// <summary>
		/// Gets or sets A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Value { get; set; }
	}
}
