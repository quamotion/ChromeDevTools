using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StartTrackingHeapObjects)]
	[SupportedBy("Chrome-Tip")]
	public class StartTrackingHeapObjectsCommand
	{
		/// <summary>
		/// Gets or sets TrackAllocations
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool TrackAllocations { get; set; }
	}
}
