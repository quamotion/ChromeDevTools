using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	[CommandResponse(ProtocolName.Database.ExecuteSQL)]
	[SupportedBy("Chrome-Tip")]
	public class ExecuteSQLCommandResponse
	{
		/// <summary>
		/// Gets or sets ColumnNames
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[] ColumnNames { get; set; }
		/// <summary>
		/// Gets or sets Values
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object[] Values { get; set; }
		/// <summary>
		/// Gets or sets SqlError
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Error SqlError { get; set; }
	}
}
