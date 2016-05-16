using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Controls the visibility of compositing borders.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetCompositingBordersVisible)]
	[SupportedBy("iOS-9.3")]
	public class SetCompositingBordersVisibleCommandResponse
	{
	}
}
