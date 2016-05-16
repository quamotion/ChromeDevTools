using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("Chrome-Tip")]
	public class GetDatabaseTableNamesCommand
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string DatabaseId { get; set; }
	}
}
