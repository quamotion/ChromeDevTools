using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetShowPaintRects)]
	[SupportedBy("iOS-9.3")]
	public class SetShowPaintRectsCommandResponse
	{
	}
}
