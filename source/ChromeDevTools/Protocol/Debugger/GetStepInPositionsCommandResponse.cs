using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Lists all positions where step-in is possible for a current statement in a specified call frame
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetStepInPositions)]
	[SupportedBy("Chrome-Tip")]
	public class GetStepInPositionsCommandResponse
	{
		/// <summary>
		/// Gets or sets experimental
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Location[] StepInPositions { get; set; }
	}
}
