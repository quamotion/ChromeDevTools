using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Key.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class Key
	{
		/// <summary>
		/// Gets or sets Key type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Number value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public double Number { get; set; }
		/// <summary>
		/// Gets or sets String value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string String { get; set; }
		/// <summary>
		/// Gets or sets Date value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public double Date { get; set; }
		/// <summary>
		/// Gets or sets Array value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Key[] Array { get; set; }
	}
}
