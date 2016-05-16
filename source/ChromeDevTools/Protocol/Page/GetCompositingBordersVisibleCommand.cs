using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Indicates the visibility of compositing borders.
	/// </summary>
	[Command(ProtocolName.Page.GetCompositingBordersVisible)]
	[SupportedBy("iOS-9.3")]
	public class GetCompositingBordersVisibleCommand
	{
	}
}
