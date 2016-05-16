using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns source for the script with given id.
	/// </summary>
	[Command(ProtocolName.Debugger.GetScriptSource)]
	[SupportedBy("Chrome-Tip")]
	public class GetScriptSourceCommand
	{
		/// <summary>
		/// Gets or sets Id of the script to get source for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
	}
}
