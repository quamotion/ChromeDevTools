using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	/// <summary>
	/// If heap objects tracking has been started then backend regulary sends a current value for last seen object id and corresponding timestamp. If the were changes in the heap since last event then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
	/// </summary>
	[Event(ProtocolName.HeapProfiler.LastSeenObjectId)]
	[SupportedBy("Chrome-Tip")]
	public class LastSeenObjectIdEvent
	{
		/// <summary>
		/// Gets or sets LastSeenObjectId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long LastSeenObjectId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
	}
}
