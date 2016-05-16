using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestData)]
	[SupportedBy("Chrome-Tip")]
	public class RequestDataCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or sets Object store name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Gets or sets Index name, empty string for object store data requests.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string IndexName { get; set; }
		/// <summary>
		/// Gets or sets Number of records to skip.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long SkipCount { get; set; }
		/// <summary>
		/// Gets or sets Number of records to fetch.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long PageSize { get; set; }
		/// <summary>
		/// Gets or sets Key range.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public KeyRange KeyRange { get; set; }
	}
}
