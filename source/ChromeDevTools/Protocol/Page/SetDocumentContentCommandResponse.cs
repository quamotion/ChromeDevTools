using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDocumentContent)]
	[SupportedBy("Chrome-Tip")]
	public class SetDocumentContentCommandResponse
	{
	}
}
