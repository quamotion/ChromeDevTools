using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	/// <summary>
	/// Database error.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Error
	{
		/// <summary>
		/// Gets or sets Error message.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Error code.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Code { get; set; }
	}
}
