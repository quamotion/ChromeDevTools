using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestData)]
	[SupportedBy("Chrome-Tip")]
	public class RequestDataCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of object store data entries.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public DataEntry[] ObjectStoreDataEntries { get; set; }
		/// <summary>
		/// Gets or sets If true, there are more entries to fetch in the given range.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool HasMore { get; set; }
	}
}
