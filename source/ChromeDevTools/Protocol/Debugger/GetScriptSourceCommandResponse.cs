using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns source for the script with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetScriptSource)]
	[SupportedBy("Chrome-Tip")]
	public class GetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets Script source.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptSource { get; set; }
	}
}
