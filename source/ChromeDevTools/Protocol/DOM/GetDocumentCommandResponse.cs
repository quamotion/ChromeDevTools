using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetDocument)]
	[SupportedBy("Chrome-Tip")]
	public class GetDocumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Node Root { get; set; }
	}
}
