using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("Chrome-Tip")]
	public class RequestDatabaseNamesCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SecurityOrigin { get; set; }
	}
}
