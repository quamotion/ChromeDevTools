using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Stack entry for console errors and assertions.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CallFrame
	{
		/// <summary>
		/// Gets or sets JavaScript function name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script name or url.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script line number.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script column number.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ColumnNumber { get; set; }
	}
}
