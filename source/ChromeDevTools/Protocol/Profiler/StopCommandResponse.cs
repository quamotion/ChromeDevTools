using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	[CommandResponse(ProtocolName.Profiler.Stop)]
	[SupportedBy("Chrome-Tip")]
	public class StopCommandResponse
	{
		/// <summary>
		/// Gets or sets Recorded profile.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CPUProfile Profile { get; set; }
	}
}
