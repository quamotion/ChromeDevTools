using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns detailed informtation on given function.
	/// </summary>
	[Command(ProtocolName.Runtime.GetRuntimeTypesForVariablesAtOffsets)]
	[SupportedBy("iOS-9.3")]
	public class GetRuntimeTypesForVariablesAtOffsetsCommand
	{
		/// <summary>
		/// Gets or sets An array of type locations we're requesting information for. Results are expected in the same order they're sent in.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public TypeLocation[] Locations { get; set; }
	}
}
