using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information on given function.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetFunctionDetails)]
	[SupportedBy("Chrome-Tip")]
	public class GetFunctionDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public FunctionDetails Details { get; set; }
	}
}
