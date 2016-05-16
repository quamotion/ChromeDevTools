using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>
	[Command(ProtocolName.DOM.GetDocument)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class GetDocumentCommand
	{
	}
}
