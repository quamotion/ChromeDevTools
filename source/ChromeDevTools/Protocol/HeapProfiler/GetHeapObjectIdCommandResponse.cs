using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetHeapObjectId)]
	[SupportedBy("Chrome-Tip")]
	public class GetHeapObjectIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the heap snapshot object corresponding to the passed remote object id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string HeapSnapshotObjectId { get; set; }
	}
}
