using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	[Command(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class AddScriptToEvaluateOnLoadCommand
	{
		/// <summary>
		/// Gets or sets ScriptSource
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string ScriptSource { get; set; }
	}
}
