using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	[Command(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome-Tip")]
	public class AddScriptToEvaluateOnLoadCommand
	{
		/// <summary>
		/// Gets or sets ScriptSource
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptSource { get; set; }
	}
}
