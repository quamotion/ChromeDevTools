using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns detailed informtation on given function.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetRuntimeTypesForVariablesAtOffsets)]
	[SupportedBy("iOS-9.3")]
	public class GetRuntimeTypesForVariablesAtOffsetsCommandResponse
	{
		/// <summary>
		/// Gets or sets Types
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public TypeDescription[] Types { get; set; }
	}
}
