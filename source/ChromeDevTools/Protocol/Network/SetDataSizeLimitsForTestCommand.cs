using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// For testing.
	/// </summary>
	[Command(ProtocolName.Network.SetDataSizeLimitsForTest)]
	[SupportedBy("Chrome-Tip")]
	public class SetDataSizeLimitsForTestCommand
	{
		/// <summary>
		/// Gets or sets Maximum total buffer size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MaxTotalSize { get; set; }
		/// <summary>
		/// Gets or sets Maximum per-resource size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MaxResourceSize { get; set; }
	}
}
