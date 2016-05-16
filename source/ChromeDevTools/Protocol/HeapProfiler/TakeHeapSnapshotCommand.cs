using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.TakeHeapSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class TakeHeapSnapshotCommand
	{
		/// <summary>
		/// Gets or sets If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool ReportProgress { get; set; }
	}
}
