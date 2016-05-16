using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	/// <summary>
	/// Database object.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class Database
	{
		/// <summary>
		/// Gets or sets Database ID.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Database domain.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Database version.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Version { get; set; }
	}
}
