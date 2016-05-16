using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
	/// </summary>
	[Command(ProtocolName.HeapProfiler.AddInspectedHeapObject)]
	[SupportedBy("Chrome-Tip")]
	public class AddInspectedHeapObjectCommand
	{
		/// <summary>
		/// Gets or sets Heap snapshot object id to be accessible by means of $x command line API.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string HeapObjectId { get; set; }
	}
}
