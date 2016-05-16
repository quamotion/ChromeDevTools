using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.GetCategories)]
	[SupportedBy("Chrome-Tip")]
	public class GetCategoriesCommandResponse
	{
		/// <summary>
		/// Gets or sets A list of supported tracing categories.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[] Categories { get; set; }
	}
}
