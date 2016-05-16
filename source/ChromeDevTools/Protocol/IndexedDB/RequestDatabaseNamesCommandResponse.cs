using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("Chrome-Tip")]
	public class RequestDatabaseNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Database names for origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[] DatabaseNames { get; set; }
	}
}
