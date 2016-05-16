using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// For testing.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetDataSizeLimitsForTest)]
	[SupportedBy("Chrome-Tip")]
	public class SetDataSizeLimitsForTestCommandResponse
	{
	}
}
