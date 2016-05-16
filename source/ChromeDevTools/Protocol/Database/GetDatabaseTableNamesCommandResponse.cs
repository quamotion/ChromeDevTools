using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	[CommandResponse(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("Chrome-Tip")]
	public class GetDatabaseTableNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets TableNames
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[] TableNames { get; set; }
	}
}
