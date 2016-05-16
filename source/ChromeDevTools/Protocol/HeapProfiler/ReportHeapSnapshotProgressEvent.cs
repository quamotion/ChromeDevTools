using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.ReportHeapSnapshotProgress)]
	[SupportedBy("Chrome-Tip")]
	public class ReportHeapSnapshotProgressEvent
	{
		/// <summary>
		/// Gets or sets Done
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Done { get; set; }
		/// <summary>
		/// Gets or sets Total
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Total { get; set; }
		/// <summary>
		/// Gets or sets Finished
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Finished { get; set; }
	}
}
