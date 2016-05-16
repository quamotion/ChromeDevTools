using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetObjectByHeapObjectId)]
	[SupportedBy("Chrome-Tip")]
	public class GetObjectByHeapObjectIdCommand
	{
		/// <summary>
		/// Gets or sets ObjectId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectGroup { get; set; }
	}
}
