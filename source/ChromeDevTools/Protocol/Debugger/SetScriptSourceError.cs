using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Error data for setScriptSource command. compileError is a case type for uncompilable script source error.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class SetScriptSourceError
	{
		/// <summary>
		/// Gets or sets CompileError
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object CompileError { get; set; }
	}
}
