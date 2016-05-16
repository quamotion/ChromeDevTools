using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	[CommandResponse(ProtocolName.Runtime.IsRunRequired)]
	[SupportedBy("Chrome-Tip")]
	public class IsRunRequiredCommandResponse
	{
		/// <summary>
		/// Gets or sets True if the Runtime is in paused on start state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Result { get; set; }
	}
}
