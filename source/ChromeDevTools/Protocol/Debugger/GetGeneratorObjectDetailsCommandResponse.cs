using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information on given generator object.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetGeneratorObjectDetails)]
	[SupportedBy("Chrome-Tip")]
	public class GetGeneratorObjectDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about the generator object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public GeneratorObjectDetails Details { get; set; }
	}
}
