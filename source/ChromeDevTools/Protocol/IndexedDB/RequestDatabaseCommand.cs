using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabase)]
	[SupportedBy("Chrome-Tip")]
	public class RequestDatabaseCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string DatabaseName { get; set; }
	}
}
