using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.AddHeapSnapshotChunk)]
	[SupportedBy("Chrome-Tip")]
	public class AddHeapSnapshotChunkEvent
	{
		/// <summary>
		/// Gets or sets Chunk
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Chunk { get; set; }
	}
}
