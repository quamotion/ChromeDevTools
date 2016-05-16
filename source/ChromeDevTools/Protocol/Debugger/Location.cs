using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Location in the source code.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Location
	{
		/// <summary>
		/// Gets or sets Script identifier as reported in the <code>Debugger.scriptParsed</code>.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Line number in the script (0-based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Column number in the script (0-based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ColumnNumber { get; set; }
	}
}
