using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	[Command(ProtocolName.Database.ExecuteSQL)]
	[SupportedBy("Chrome-Tip")]
	public class ExecuteSQLCommand
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string DatabaseId { get; set; }
		/// <summary>
		/// Gets or sets Query
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Query { get; set; }
	}
}
