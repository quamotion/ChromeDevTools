using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Describes the accuracy level of the data provider.
	/// </summary>
	[CommandResponse(ProtocolName.Power.GetAccuracyLevel)]
	[SupportedBy("Chrome-Tip")]
	public class GetAccuracyLevelCommandResponse
	{
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Result { get; set; }
	}
}
