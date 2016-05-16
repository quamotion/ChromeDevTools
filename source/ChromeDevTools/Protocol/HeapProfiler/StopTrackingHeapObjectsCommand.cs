using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StopTrackingHeapObjects)]
	[SupportedBy("Chrome-Tip")]
	public class StopTrackingHeapObjectsCommand
	{
		/// <summary>
		/// Gets or sets If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken when the tracking is stopped.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool ReportProgress { get; set; }
	}
}
