using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>
	[CommandResponse(ProtocolName.Worker.CanInspectWorkers)]
	[SupportedBy("iOS-9.3")]
	public class CanInspectWorkersCommandResponse
	{
		/// <summary>
		/// Gets or sets True if browser has workers support.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Result { get; set; }
	}
}
