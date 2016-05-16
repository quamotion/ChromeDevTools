using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetHeapObjectId)]
	[SupportedBy("Chrome-Tip")]
	public class GetHeapObjectIdCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to get heap object id for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectId { get; set; }
	}
}
