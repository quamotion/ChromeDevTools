using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Runs script with given id in a given context.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RunScript)]
	[SupportedBy("Chrome-Tip")]
	public class RunScriptCommandResponse
	{
		/// <summary>
		/// Gets or sets Run result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
