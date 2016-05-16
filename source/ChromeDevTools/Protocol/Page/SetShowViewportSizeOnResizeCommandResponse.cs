using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetShowViewportSizeOnResize)]
	[SupportedBy("Chrome-Tip")]
	public class SetShowViewportSizeOnResizeCommandResponse
	{
	}
}
