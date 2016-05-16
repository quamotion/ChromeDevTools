using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Compiles expression.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.CompileScript)]
	[SupportedBy("Chrome-Tip")]
	public class CompileScriptCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the script.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
