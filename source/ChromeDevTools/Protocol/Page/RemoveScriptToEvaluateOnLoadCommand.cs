using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	[Command(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveScriptToEvaluateOnLoadCommand
	{
		/// <summary>
		/// Gets or sets Identifier
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Identifier { get; set; }
	}
}
