using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Key path.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class KeyPath
	{
		/// <summary>
		/// Gets or sets Key path type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets String value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string String { get; set; }
		/// <summary>
		/// Gets or sets Array value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[] Array { get; set; }
	}
}
