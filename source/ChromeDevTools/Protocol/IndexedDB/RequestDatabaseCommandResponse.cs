using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestDatabase)]
	[SupportedBy("Chrome-Tip")]
	public class RequestDatabaseCommandResponse
	{
		/// <summary>
		/// Gets or sets Database with an array of object stores.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public DatabaseWithObjectStores DatabaseWithObjectStores { get; set; }
	}
}
