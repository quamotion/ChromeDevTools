using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CustomPreview
	{
		/// <summary>
		/// Gets or sets Header
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Header { get; set; }
		/// <summary>
		/// Gets or sets HasBody
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool HasBody { get; set; }
		/// <summary>
		/// Gets or sets FormatterObjectId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FormatterObjectId { get; set; }
		/// <summary>
		/// Gets or sets ConfigObjectId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ConfigObjectId { get; set; }
	}
}
