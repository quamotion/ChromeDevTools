using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Data entry.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class DataEntry
	{
		/// <summary>
		/// Gets or sets JSON-stringified key object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets JSON-stringified primary key object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string PrimaryKey { get; set; }
		/// <summary>
		/// Gets or sets JSON-stringified value object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
	}
}
