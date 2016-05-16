using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetObjectByHeapObjectId)]
	[SupportedBy("Chrome-Tip")]
	public class GetObjectByHeapObjectIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Evaluation result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Result { get; set; }
	}
}
